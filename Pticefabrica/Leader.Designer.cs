
namespace Pticefabrica
{
    partial class Leader
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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CehLabel = new System.Windows.Forms.Label();
            this.CehBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.ProdBtn = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.PartLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.OtchetLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.FormOtchet = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.MaxCikl = new System.Windows.Forms.NumericUpDown();
            this.MaxKolvoN = new System.Windows.Forms.NumericUpDown();
            this.MaxKolvoB = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxCikl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxKolvoN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxKolvoB)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Location = new System.Drawing.Point(773, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Управляющий";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(0, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 420);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CehLabel);
            this.tabPage1.Controls.Add(this.CehBtn);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Цеха";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CehLabel
            // 
            this.CehLabel.AutoSize = true;
            this.CehLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CehLabel.Location = new System.Drawing.Point(8, 358);
            this.CehLabel.Name = "CehLabel";
            this.CehLabel.Size = new System.Drawing.Size(0, 21);
            this.CehLabel.TabIndex = 6;
            // 
            // CehBtn
            // 
            this.CehBtn.Location = new System.Drawing.Point(8, 312);
            this.CehBtn.Name = "CehBtn";
            this.CehBtn.Size = new System.Drawing.Size(196, 23);
            this.CehBtn.TabIndex = 5;
            this.CehBtn.Text = "Очистить цех";
            this.CehBtn.UseVisualStyleBackColor = true;
            this.CehBtn.Click += new System.EventHandler(this.CehBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Репродуктор",
            "Инкубаторы",
            "Птичники",
            "Комплексы производства яиц",
            "УПК"});
            this.comboBox1.Location = new System.Drawing.Point(8, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.Relaod1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(6, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(787, 274);
            this.listBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ProductLabel);
            this.tabPage2.Controls.Add(this.ProdBtn);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.listBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Готовая продукция";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductLabel.Location = new System.Drawing.Point(8, 348);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(0, 21);
            this.ProductLabel.TabIndex = 4;
            // 
            // ProdBtn
            // 
            this.ProdBtn.Location = new System.Drawing.Point(8, 312);
            this.ProdBtn.Name = "ProdBtn";
            this.ProdBtn.Size = new System.Drawing.Size(196, 23);
            this.ProdBtn.TabIndex = 3;
            this.ProdBtn.Text = "Удалить партию продукции";
            this.ProdBtn.UseVisualStyleBackColor = true;
            this.ProdBtn.Click += new System.EventHandler(this.ProdBtn_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Меланж",
            "Фабрикат",
            "Партии товарных яиц"});
            this.comboBox2.Location = new System.Drawing.Point(8, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(196, 23);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.Reload2);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(8, 32);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(782, 274);
            this.listBox2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.PartLabel);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.comboBox3);
            this.tabPage3.Controls.Add(this.listBox5);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(793, 392);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Партии";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // PartLabel
            // 
            this.PartLabel.AutoSize = true;
            this.PartLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PartLabel.Location = new System.Drawing.Point(8, 354);
            this.PartLabel.Name = "PartLabel";
            this.PartLabel.Size = new System.Drawing.Size(0, 21);
            this.PartLabel.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Удалить партию";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Партии яиц родительского стада",
            "Партии молодняка",
            "Партии взрослой птицы",
            "Партии неотсортированных яиц"});
            this.comboBox3.Location = new System.Drawing.Point(8, 4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(215, 23);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.Reload3);
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 15;
            this.listBox5.Location = new System.Drawing.Point(3, 33);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(787, 274);
            this.listBox5.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.comboBox4);
            this.tabPage4.Controls.Add(this.OtchetLabel);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.numericUpDown2);
            this.tabPage4.Controls.Add(this.numericUpDown1);
            this.tabPage4.Controls.Add(this.FormOtchet);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(793, 392);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Отчетность";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Вид товара";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Меланж",
            "Фабрикат",
            "Партии товарных яиц",
            "Вся продукция"});
            this.comboBox4.Location = new System.Drawing.Point(147, 82);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 23);
            this.comboBox4.TabIndex = 6;
            // 
            // OtchetLabel
            // 
            this.OtchetLabel.AutoSize = true;
            this.OtchetLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OtchetLabel.Location = new System.Drawing.Point(8, 157);
            this.OtchetLabel.Name = "OtchetLabel";
            this.OtchetLabel.Size = new System.Drawing.Size(0, 21);
            this.OtchetLabel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Год";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Квартал";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(147, 40);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            2034,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown2.TabIndex = 2;
            this.numericUpDown2.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(8, 40);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormOtchet
            // 
            this.FormOtchet.Location = new System.Drawing.Point(8, 131);
            this.FormOtchet.Name = "FormOtchet";
            this.FormOtchet.Size = new System.Drawing.Size(177, 23);
            this.FormOtchet.TabIndex = 0;
            this.FormOtchet.Text = "Сформировать отчет";
            this.FormOtchet.UseVisualStyleBackColor = true;
            this.FormOtchet.Click += new System.EventHandler(this.FormOtchet_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.button1);
            this.tabPage5.Controls.Add(this.MaxCikl);
            this.tabPage5.Controls.Add(this.MaxKolvoN);
            this.tabPage5.Controls.Add(this.MaxKolvoB);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(793, 392);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Управление";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Количество циклов несения у несушек";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(291, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Необходимое количество несушек в репродукторе";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(304, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Необходимое количество бройлеров в репродукторе";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Установить новые значения";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MaxCikl
            // 
            this.MaxCikl.Location = new System.Drawing.Point(8, 157);
            this.MaxCikl.Name = "MaxCikl";
            this.MaxCikl.Size = new System.Drawing.Size(120, 23);
            this.MaxCikl.TabIndex = 15;
            // 
            // MaxKolvoN
            // 
            this.MaxKolvoN.Location = new System.Drawing.Point(8, 103);
            this.MaxKolvoN.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.MaxKolvoN.Name = "MaxKolvoN";
            this.MaxKolvoN.Size = new System.Drawing.Size(120, 23);
            this.MaxKolvoN.TabIndex = 14;
            // 
            // MaxKolvoB
            // 
            this.MaxKolvoB.Location = new System.Drawing.Point(8, 41);
            this.MaxKolvoB.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.MaxKolvoB.Name = "MaxKolvoB";
            this.MaxKolvoB.Size = new System.Drawing.Size(120, 23);
            this.MaxKolvoB.TabIndex = 13;
            // 
            // Leader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Leader";
            this.Text = "Leader";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxCikl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxKolvoN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxKolvoB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button FormOtchet;
        private System.Windows.Forms.Label OtchetLabel;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown MaxCikl;
        private System.Windows.Forms.NumericUpDown MaxKolvoN;
        private System.Windows.Forms.NumericUpDown MaxKolvoB;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button ProdBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.Label CehLabel;
        private System.Windows.Forms.Button CehBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label PartLabel;
    }
}