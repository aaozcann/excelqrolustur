using MessagingToolkit.QRCode.Codec;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ExcelQrCodeGenerator
{
    public partial class Form1 : Form
    {
        DataTable Datalar;
        FolderBrowserDialog fbd = new FolderBrowserDialog();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var masaustuPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string qrPath = masaustuPath + "\\QR\\";

            klasor_txt.Text = qrPath;
        }

        private void yapistir_sagTik_cms_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                PasteData(Clipboard.GetText());
            }
        }

        private void klasorSec_btn_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                klasor_txt.Text = fbd.SelectedPath + "\\";
            }
        }

        private void logKopyala_btn_Click(object sender, EventArgs e)
        {
            string text = "";
            foreach (var item in islem_lb.Items)
            {
                text += item.ToString() + Environment.NewLine;
            }

            Clipboard.SetData(DataFormats.Text, text);
            MessageBox.Show("LOGLAR HAFIZAYA KOPYALANDI...");
        }

        private void islem_lb_DoubleClick(object sender, EventArgs e)
        {
            string s = islem_lb.SelectedItem.ToString();
            Clipboard.SetData(DataFormats.StringFormat, s);
            MessageBox.Show("Kopyalandı");
        }
        void PrepareTable()
        {
            ArrayList columns = new ArrayList();
            ArrayList columnswithblank = new ArrayList();
            columnswithblank.Add("-");
            for (int i = 0; i < Datalar.Columns.Count; i++)
            {
                columns.Add(Datalar.Columns[i].ColumnName);
                columnswithblank.Add(Datalar.Columns[i].ColumnName);
            }

            qr_cb.Items.Clear();
            qr_cb.Items.AddRange(columns.ToArray());
            qr_cb.SelectedIndex = 0;

            dosyaAdi_cb.Items.Clear();
            dosyaAdi_cb.Items.AddRange(columns.ToArray());
            dosyaAdi_cb.SelectedIndex = 1;

            gb_2.Enabled = true;
        }
        private void PasteData(string pClipboard)
        {
            List<List<string>> table = new List<List<string>>();

            string importText = pClipboard;

            importText = importText.Replace("\n", "");

            string[] lines = importText.Split('\r');
            for (int x = 0; x < lines.Length; x++)
            {
                if (string.IsNullOrEmpty(lines[x]))
                {
                    break;
                }

                List<string> cellsList = new List<string>();
                string[] cells = lines[x].Split('\t');

                cellsList.AddRange(cells);

                table.Add(cellsList);
            }
            try
            {
                Datalar = new DataTable();
                for (int x = 0; x < table.Count; x++)
                {
                    if (Datalar.Columns.Count == 0)
                    {
                        for (int i = 0; i < table[x].Count; i++)
                        {
                            Datalar.Columns.Add("Column" + (i));
                        }
                    }
                    DataRow row = Datalar.NewRow();
                    for (int y = 0; y < table[x].Count; y++)
                    {
                        row[y] = table[x][y];
                    }
                    Datalar.Rows.Add(row);
                }

                if (Datalar.Rows.Count > 0)
                {
                    PrepareTable();
                    excel_dgv.DataSource = Datalar;
                }
            }
            catch
            {
            }
        }
        private void LogEkle(string log)
        {
            Application.DoEvents(); Application.DoEvents();
            islem_lb.Items.Add(log);
            int visibleItems = islem_lb.ClientSize.Height / islem_lb.ItemHeight;
            islem_lb.TopIndex = Math.Max(islem_lb.Items.Count - visibleItems + 1, 0);
            Application.DoEvents(); Application.DoEvents();
        }

        private void islemYap_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("İşlem başlayacaktır?", "Emin misiniz!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                LogEkle("İŞLEM İPTAL EDİLDİ....");
                return;
            }

            if (!Directory.Exists(klasor_txt.Text))
            {
                Directory.CreateDirectory(klasor_txt.Text);
            }

            gb_1.Enabled = false;
            gb_2.Enabled = false;
            gb_4.Enabled = true;

            DateTime baslangic = DateTime.Now;

            LogEkle(":: BAŞLADI ::");

            pb_1.Maximum = Datalar.Rows.Count;
            pb_1.Value = 0;

            for (int i = 0; i < Datalar.Rows.Count; i++)
            {
                pb_1.Value++;
                Application.DoEvents();

                var qrSTR = Datalar.Rows[i][qr_cb.Text.Trim()].ToString().Trim();
                var dosyaAdi = Datalar.Rows[i][dosyaAdi_cb.Text.Trim()].ToString().Trim();

                if (qrSTR == "")
                    continue;

                if (dosyaAdi == "")
                    continue;

                try
                {
                    if(getQrTiffPath(qrSTR, dosyaAdi.ToString()))
                        LogEkle("Oluşturuldu. DosyaAdi:" + dosyaAdi);
                    else
                        LogEkle("Oluşturulmadı. DosyaAdi:" + dosyaAdi);
                }
                catch (Exception)
                {
                    LogEkle("Oluşturulmadı. DosyaAdi:" + dosyaAdi);
                }
            }

            LogEkle(":: BTTİ ::");
            gb_1.Enabled = true;
            gb_2.Enabled = true;

            MessageBox.Show("İşlem tamamlandı", "Bitti!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private Bitmap DrawFilledRectangle(int x, int y)
        {
            Bitmap bmp = new Bitmap(x, y);
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                System.Drawing.Rectangle ImageSize = new System.Drawing.Rectangle(0, 0, x, y);
                graph.FillRectangle(System.Drawing.Brushes.White, ImageSize);
            }
            return bmp;
        }

        private bool getQrTiffPath(string qr, string fileName, int scale = 6)
        {
            QRCodeEncoder encoder = new QRCodeEncoder();
            encoder.QRCodeForegroundColor = System.Drawing.Color.FromArgb(0, 0, 0);
            encoder.QRCodeScale = scale;

            System.Drawing.Bitmap tempImg = encoder.Encode(qr);
            tempImg.RotateFlip(RotateFlipType.Rotate180FlipNone);
            System.Drawing.Bitmap img = DrawFilledRectangle(tempImg.Width + 20, tempImg.Height + 20);

            using (Graphics grfx = Graphics.FromImage(img))
            {
                grfx.DrawImage(tempImg, 10, 10);
            }

            string pngPath = Path.Combine(klasor_txt.Text, fileName + ".png");
            var tiffPath = Path.Combine(klasor_txt.Text, fileName + ".tiff");

            if (File.Exists(pngPath))
                File.Delete(pngPath);

            if (File.Exists(tiffPath))
                File.Delete(tiffPath);

            img.Save(pngPath, System.Drawing.Imaging.ImageFormat.Png);
            Stream imgSt = new FileStream(pngPath, FileMode.Open, FileAccess.Read, FileShare.Read);
            BitmapSource myBitmapSource = BitmapFrame.Create(imgSt);
            FormatConvertedBitmap newFormatedBitmapSource = new FormatConvertedBitmap();
            newFormatedBitmapSource.BeginInit();
            newFormatedBitmapSource.Source = myBitmapSource;
            newFormatedBitmapSource.DestinationFormat = PixelFormats.Cmyk32;
            newFormatedBitmapSource.EndInit();

            BitmapEncoder enc = new TiffBitmapEncoder();
            enc.Frames.Add(BitmapFrame.Create(newFormatedBitmapSource));
            
            Stream cmykStream = new FileStream(tiffPath, FileMode.Create, FileAccess.Write, FileShare.Write);
            enc.Save(cmykStream);
            cmykStream.Close();
            imgSt.Close();

            if (File.Exists(tiffPath))
                return true;
            else
                return false;
        }
    }
}
