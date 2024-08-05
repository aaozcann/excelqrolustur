namespace ExcelQrCodeGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gb_1 = new System.Windows.Forms.GroupBox();
            this.gb_2 = new System.Windows.Forms.GroupBox();
            this.gb_3 = new System.Windows.Forms.GroupBox();
            this.gb_4 = new System.Windows.Forms.GroupBox();
            this.excel_dgv = new System.Windows.Forms.DataGridView();
            this.sagTig_cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yapistir_sagTik_cms = new System.Windows.Forms.ToolStripMenuItem();
            this.pb_1 = new System.Windows.Forms.ProgressBar();
            this.islem_lb = new System.Windows.Forms.ListBox();
            this.logKopyala_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.islemYap_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.klasor_txt = new System.Windows.Forms.TextBox();
            this.klasorSec_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.qr_cb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dosyaAdi_cb = new System.Windows.Forms.ComboBox();
            this.gb_1.SuspendLayout();
            this.gb_2.SuspendLayout();
            this.gb_3.SuspendLayout();
            this.gb_4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.excel_dgv)).BeginInit();
            this.sagTig_cms.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_1
            // 
            this.gb_1.Controls.Add(this.excel_dgv);
            this.gb_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_1.Location = new System.Drawing.Point(0, 0);
            this.gb_1.Name = "gb_1";
            this.gb_1.Size = new System.Drawing.Size(1442, 314);
            this.gb_1.TabIndex = 0;
            this.gb_1.TabStop = false;
            this.gb_1.Text = "Excel Kopyala";
            // 
            // gb_2
            // 
            this.gb_2.Controls.Add(this.groupBox2);
            this.gb_2.Controls.Add(this.groupBox1);
            this.gb_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_2.Enabled = false;
            this.gb_2.Location = new System.Drawing.Point(0, 314);
            this.gb_2.Name = "gb_2";
            this.gb_2.Size = new System.Drawing.Size(1442, 143);
            this.gb_2.TabIndex = 1;
            this.gb_2.TabStop = false;
            this.gb_2.Text = "İŞLEM YAP";
            // 
            // gb_3
            // 
            this.gb_3.Controls.Add(this.pb_1);
            this.gb_3.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_3.Location = new System.Drawing.Point(0, 457);
            this.gb_3.Name = "gb_3";
            this.gb_3.Size = new System.Drawing.Size(1442, 57);
            this.gb_3.TabIndex = 2;
            this.gb_3.TabStop = false;
            this.gb_3.Text = "İşlem";
            // 
            // gb_4
            // 
            this.gb_4.Controls.Add(this.logKopyala_btn);
            this.gb_4.Controls.Add(this.islem_lb);
            this.gb_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_4.Enabled = false;
            this.gb_4.Location = new System.Drawing.Point(0, 514);
            this.gb_4.Name = "gb_4";
            this.gb_4.Size = new System.Drawing.Size(1442, 249);
            this.gb_4.TabIndex = 3;
            this.gb_4.TabStop = false;
            this.gb_4.Text = "Loglar";
            // 
            // excel_dgv
            // 
            this.excel_dgv.AllowUserToAddRows = false;
            this.excel_dgv.AllowUserToDeleteRows = false;
            this.excel_dgv.AllowUserToOrderColumns = true;
            this.excel_dgv.AllowUserToResizeRows = false;
            this.excel_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.excel_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.excel_dgv.ContextMenuStrip = this.sagTig_cms;
            this.excel_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.excel_dgv.Location = new System.Drawing.Point(3, 16);
            this.excel_dgv.MultiSelect = false;
            this.excel_dgv.Name = "excel_dgv";
            this.excel_dgv.ReadOnly = true;
            this.excel_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.excel_dgv.ShowEditingIcon = false;
            this.excel_dgv.Size = new System.Drawing.Size(1436, 295);
            this.excel_dgv.TabIndex = 0;
            // 
            // sagTig_cms
            // 
            this.sagTig_cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yapistir_sagTik_cms});
            this.sagTig_cms.Name = "sagTig_cms";
            this.sagTig_cms.Size = new System.Drawing.Size(113, 26);
            // 
            // yapistir_sagTik_cms
            // 
            this.yapistir_sagTik_cms.Name = "yapistir_sagTik_cms";
            this.yapistir_sagTik_cms.Size = new System.Drawing.Size(112, 22);
            this.yapistir_sagTik_cms.Text = "Yapıştır";
            this.yapistir_sagTik_cms.MouseDown += new System.Windows.Forms.MouseEventHandler(this.yapistir_sagTik_cms_MouseDown);
            // 
            // pb_1
            // 
            this.pb_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_1.Location = new System.Drawing.Point(3, 16);
            this.pb_1.Name = "pb_1";
            this.pb_1.Size = new System.Drawing.Size(1436, 38);
            this.pb_1.TabIndex = 0;
            // 
            // islem_lb
            // 
            this.islem_lb.Dock = System.Windows.Forms.DockStyle.Top;
            this.islem_lb.FormattingEnabled = true;
            this.islem_lb.Location = new System.Drawing.Point(3, 16);
            this.islem_lb.Name = "islem_lb";
            this.islem_lb.Size = new System.Drawing.Size(1436, 199);
            this.islem_lb.TabIndex = 0;
            this.islem_lb.DoubleClick += new System.EventHandler(this.islem_lb_DoubleClick);
            // 
            // logKopyala_btn
            // 
            this.logKopyala_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logKopyala_btn.Location = new System.Drawing.Point(3, 215);
            this.logKopyala_btn.Name = "logKopyala_btn";
            this.logKopyala_btn.Size = new System.Drawing.Size(1436, 31);
            this.logKopyala_btn.TabIndex = 1;
            this.logKopyala_btn.Text = "< Logları Kopyala >";
            this.logKopyala_btn.UseVisualStyleBackColor = true;
            this.logKopyala_btn.Click += new System.EventHandler(this.logKopyala_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dosyaAdi_cb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.qr_cb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.islemYap_btn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(1436, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 80);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(1436, 60);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(0, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox3.Size = new System.Drawing.Size(194, 47);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.klasor_txt);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(194, 13);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox4.Size = new System.Drawing.Size(1039, 47);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.klasorSec_btn);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(1233, 13);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox5.Size = new System.Drawing.Size(203, 47);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // islemYap_btn
            // 
            this.islemYap_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.islemYap_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.islemYap_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islemYap_btn.Location = new System.Drawing.Point(0, 13);
            this.islemYap_btn.Margin = new System.Windows.Forms.Padding(0);
            this.islemYap_btn.Name = "islemYap_btn";
            this.islemYap_btn.Size = new System.Drawing.Size(846, 51);
            this.islemYap_btn.TabIndex = 0;
            this.islemYap_btn.Text = "< QR ÜRET >";
            this.islemYap_btn.UseVisualStyleBackColor = false;
            this.islemYap_btn.Click += new System.EventHandler(this.islemYap_btn_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dosyaların Kaydedileceği Yer:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // klasor_txt
            // 
            this.klasor_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.klasor_txt.Enabled = false;
            this.klasor_txt.Location = new System.Drawing.Point(0, 13);
            this.klasor_txt.Multiline = true;
            this.klasor_txt.Name = "klasor_txt";
            this.klasor_txt.Size = new System.Drawing.Size(1039, 34);
            this.klasor_txt.TabIndex = 0;
            // 
            // klasorSec_btn
            // 
            this.klasorSec_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.klasorSec_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.klasorSec_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.klasorSec_btn.Location = new System.Drawing.Point(0, 13);
            this.klasorSec_btn.Name = "klasorSec_btn";
            this.klasorSec_btn.Size = new System.Drawing.Size(203, 34);
            this.klasorSec_btn.TabIndex = 0;
            this.klasorSec_btn.Text = "<Klasor Sec>";
            this.klasorSec_btn.UseVisualStyleBackColor = false;
            this.klasorSec_btn.Click += new System.EventHandler(this.klasorSec_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(887, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "QR: ";
            // 
            // qr_cb
            // 
            this.qr_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.qr_cb.FormattingEnabled = true;
            this.qr_cb.Location = new System.Drawing.Point(923, 32);
            this.qr_cb.Name = "qr_cb";
            this.qr_cb.Size = new System.Drawing.Size(214, 21);
            this.qr_cb.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1155, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Dosya Adi:";
            // 
            // dosyaAdi_cb
            // 
            this.dosyaAdi_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dosyaAdi_cb.FormattingEnabled = true;
            this.dosyaAdi_cb.Location = new System.Drawing.Point(1222, 32);
            this.dosyaAdi_cb.Name = "dosyaAdi_cb";
            this.dosyaAdi_cb.Size = new System.Drawing.Size(214, 21);
            this.dosyaAdi_cb.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 763);
            this.Controls.Add(this.gb_4);
            this.Controls.Add(this.gb_3);
            this.Controls.Add(this.gb_2);
            this.Controls.Add(this.gb_1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel ile QR Kodu Oluşturma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_1.ResumeLayout(false);
            this.gb_2.ResumeLayout(false);
            this.gb_3.ResumeLayout(false);
            this.gb_4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.excel_dgv)).EndInit();
            this.sagTig_cms.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_1;
        private System.Windows.Forms.DataGridView excel_dgv;
        private System.Windows.Forms.ContextMenuStrip sagTig_cms;
        private System.Windows.Forms.ToolStripMenuItem yapistir_sagTik_cms;
        private System.Windows.Forms.GroupBox gb_2;
        private System.Windows.Forms.GroupBox gb_3;
        private System.Windows.Forms.GroupBox gb_4;
        private System.Windows.Forms.ProgressBar pb_1;
        private System.Windows.Forms.Button logKopyala_btn;
        private System.Windows.Forms.ListBox islem_lb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button klasorSec_btn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox klasor_txt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button islemYap_btn;
        private System.Windows.Forms.ComboBox dosyaAdi_cb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox qr_cb;
        private System.Windows.Forms.Label label2;
    }
}

