namespace cmd_magaza
{
    partial class Anaform
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMusteri = new System.Windows.Forms.ToolStripButton();
            this.BtnUrunler = new System.Windows.Forms.ToolStripButton();
            this.BtnSatısYap = new System.Windows.Forms.ToolStripButton();
            this.btnOdemeYap = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.BtnSatisYap = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.Btnekle = new System.Windows.Forms.ToolStripButton();
            this.BtnDuzenle = new System.Windows.Forms.ToolStripButton();
            this.BtnSil = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnBul = new System.Windows.Forms.ToolStripButton();
            this.btnodeme = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.toolStrip5 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.btnDüzenle = new System.Windows.Forms.ToolStripButton();
            this.btnsil2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.BtnSatisYap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.btnodeme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip5.SuspendLayout();
            this.toolStrip4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMusteri,
            this.BtnUrunler,
            this.BtnSatısYap,
            this.btnOdemeYap});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(708, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnMusteri
            // 
            this.btnMusteri.Image = global::cmd_magaza.Properties.Resources.user_id;
            this.btnMusteri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(67, 22);
            this.btnMusteri.Text = "Musteri";
            // 
            // BtnUrunler
            // 
            this.BtnUrunler.Image = global::cmd_magaza.Properties.Resources.roller_transport;
            this.BtnUrunler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnUrunler.Name = "BtnUrunler";
            this.BtnUrunler.Size = new System.Drawing.Size(66, 22);
            this.BtnUrunler.Text = "Ürünler";
            // 
            // BtnSatısYap
            // 
            this.BtnSatısYap.Image = global::cmd_magaza.Properties.Resources.credit_card_back;
            this.BtnSatısYap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSatısYap.Name = "BtnSatısYap";
            this.BtnSatısYap.Size = new System.Drawing.Size(73, 22);
            this.BtnSatısYap.Text = "Satış Yap";
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.Image = global::cmd_magaza.Properties.Resources.give_money_1_add;
            this.btnOdemeYap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(88, 22);
            this.btnOdemeYap.Text = "Ödeme Yap";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.BtnSatisYap);
            this.tabControl1.Controls.Add(this.btnodeme);
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(705, 288);
            this.tabControl1.TabIndex = 1;
            // 
            // BtnSatisYap
            // 
            this.BtnSatisYap.Controls.Add(this.label1);
            this.BtnSatisYap.Controls.Add(this.textBox1);
            this.BtnSatisYap.Controls.Add(this.dataGridView1);
            this.BtnSatisYap.Controls.Add(this.toolStrip3);
            this.BtnSatisYap.Controls.Add(this.toolStrip2);
            this.BtnSatisYap.Location = new System.Drawing.Point(4, 22);
            this.BtnSatisYap.Name = "BtnSatisYap";
            this.BtnSatisYap.Padding = new System.Windows.Forms.Padding(3);
            this.BtnSatisYap.Size = new System.Drawing.Size(697, 262);
            this.BtnSatisYap.TabIndex = 0;
            this.BtnSatisYap.Text = "Satış yap";
            this.BtnSatisYap.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(527, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ara:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(559, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(695, 225);
            this.dataGridView1.TabIndex = 2;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btnekle,
            this.BtnDuzenle,
            this.BtnSil});
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(667, 25);
            this.toolStrip3.TabIndex = 1;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // Btnekle
            // 
            this.Btnekle.Image = global::cmd_magaza.Properties.Resources.give_money_1_add;
            this.Btnekle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btnekle.Name = "Btnekle";
            this.Btnekle.Size = new System.Drawing.Size(48, 22);
            this.Btnekle.Text = "Ekle";
            // 
            // BtnDuzenle
            // 
            this.BtnDuzenle.Image = global::cmd_magaza.Properties.Resources.give_money_1_update;
            this.BtnDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDuzenle.Name = "BtnDuzenle";
            this.BtnDuzenle.Size = new System.Drawing.Size(69, 22);
            this.BtnDuzenle.Text = "Düzenle";
            // 
            // BtnSil
            // 
            this.BtnSil.Image = global::cmd_magaza.Properties.Resources.give_money_1_remove;
            this.BtnSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(39, 22);
            this.BtnSil.Text = "Sil";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBul});
            this.toolStrip2.Location = new System.Drawing.Point(670, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip2.Size = new System.Drawing.Size(24, 256);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnBul
            // 
            this.btnBul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBul.Image = global::cmd_magaza.Properties.Resources.button_circle_find;
            this.btnBul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(21, 20);
            this.btnBul.Text = "toolStripButton5";
            // 
            // btnodeme
            // 
            this.btnodeme.Controls.Add(this.label2);
            this.btnodeme.Controls.Add(this.textBox2);
            this.btnodeme.Controls.Add(this.dataGridView2);
            this.btnodeme.Controls.Add(this.toolStrip5);
            this.btnodeme.Controls.Add(this.toolStrip4);
            this.btnodeme.Location = new System.Drawing.Point(4, 22);
            this.btnodeme.Name = "btnodeme";
            this.btnodeme.Padding = new System.Windows.Forms.Padding(3);
            this.btnodeme.Size = new System.Drawing.Size(697, 262);
            this.btnodeme.TabIndex = 1;
            this.btnodeme.Text = "Ödeme Yap";
            this.btnodeme.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ara:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(571, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 35);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(698, 276);
            this.dataGridView2.TabIndex = 2;
            // 
            // toolStrip5
            // 
            this.toolStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.btnDüzenle,
            this.btnsil2});
            this.toolStrip5.Location = new System.Drawing.Point(3, 3);
            this.toolStrip5.Name = "toolStrip5";
            this.toolStrip5.Size = new System.Drawing.Size(667, 25);
            this.toolStrip5.TabIndex = 1;
            this.toolStrip5.Text = "toolStrip5";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::cmd_magaza.Properties.Resources.credit_card_back_add;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(48, 22);
            this.toolStripButton2.Text = "Ekle";
            this.toolStripButton2.ToolTipText = "Ekle";
            // 
            // btnDüzenle
            // 
            this.btnDüzenle.Image = global::cmd_magaza.Properties.Resources.credit_card_back_update;
            this.btnDüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDüzenle.Name = "btnDüzenle";
            this.btnDüzenle.Size = new System.Drawing.Size(69, 22);
            this.btnDüzenle.Text = "Düzenle";
            // 
            // btnsil2
            // 
            this.btnsil2.Image = global::cmd_magaza.Properties.Resources.credit_card_back_remove;
            this.btnsil2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsil2.Name = "btnsil2";
            this.btnsil2.Size = new System.Drawing.Size(38, 22);
            this.btnsil2.Text = "sil";
            // 
            // toolStrip4
            // 
            this.toolStrip4.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip4.Location = new System.Drawing.Point(670, 3);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(24, 256);
            this.toolStrip4.TabIndex = 0;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::cmd_magaza.Properties.Resources.button_circle_find;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(21, 20);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // Anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 307);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Anaform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AnaForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.BtnSatisYap.ResumeLayout(false);
            this.BtnSatisYap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.btnodeme.ResumeLayout(false);
            this.btnodeme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip5.ResumeLayout(false);
            this.toolStrip5.PerformLayout();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnMusteri;
        private System.Windows.Forms.ToolStripButton BtnUrunler;
        private System.Windows.Forms.ToolStripButton BtnSatısYap;
        private System.Windows.Forms.ToolStripButton btnOdemeYap;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage BtnSatisYap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton Btnekle;
        private System.Windows.Forms.ToolStripButton BtnDuzenle;
        private System.Windows.Forms.ToolStripButton BtnSil;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnBul;
        private System.Windows.Forms.TabPage btnodeme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStrip toolStrip5;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton btnDüzenle;
        private System.Windows.Forms.ToolStripButton btnsil2;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

