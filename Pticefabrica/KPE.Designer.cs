
namespace Pticefabrica
{
    partial class KPE
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.KPEText = new System.Windows.Forms.Label();
            this.FormKPE = new System.Windows.Forms.Button();
            this.LoadUPK = new System.Windows.Forms.Button();
            this.ReloadKPE = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 375);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 81;
            // 
            // KPEText
            // 
            this.KPEText.AutoSize = true;
            this.KPEText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KPEText.Location = new System.Drawing.Point(235, 417);
            this.KPEText.Name = "KPEText";
            this.KPEText.Size = new System.Drawing.Size(0, 21);
            this.KPEText.TabIndex = 80;
            // 
            // FormKPE
            // 
            this.FormKPE.Location = new System.Drawing.Point(13, 415);
            this.FormKPE.Name = "FormKPE";
            this.FormKPE.Size = new System.Drawing.Size(222, 23);
            this.FormKPE.TabIndex = 79;
            this.FormKPE.Text = "Сформировать партию яиц";
            this.FormKPE.UseVisualStyleBackColor = true;
            this.FormKPE.Click += new System.EventHandler(this.FormKPE_Click);
            // 
            // LoadUPK
            // 
            this.LoadUPK.Location = new System.Drawing.Point(13, 332);
            this.LoadUPK.Name = "LoadUPK";
            this.LoadUPK.Size = new System.Drawing.Size(222, 23);
            this.LoadUPK.TabIndex = 76;
            this.LoadUPK.Text = "Отправить партию птиц в комплекс";
            this.LoadUPK.UseVisualStyleBackColor = true;
            this.LoadUPK.Click += new System.EventHandler(this.LoadUPK_Click);
            // 
            // ReloadKPE
            // 
            this.ReloadKPE.Location = new System.Drawing.Point(13, 43);
            this.ReloadKPE.Name = "ReloadKPE";
            this.ReloadKPE.Size = new System.Drawing.Size(233, 23);
            this.ReloadKPE.TabIndex = 74;
            this.ReloadKPE.Text = "Обновить данные";
            this.ReloadKPE.UseVisualStyleBackColor = true;
            this.ReloadKPE.Click += new System.EventHandler(this.ReloadKPE_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Location = new System.Drawing.Point(773, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 15);
            this.label6.TabIndex = 73;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 15);
            this.label1.TabIndex = 72;
            this.label1.Text = "Комплекс производства яиц";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 82;
            this.label2.Text = "Количество яиц";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 83;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(13, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(776, 124);
            this.listBox1.TabIndex = 75;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(12, 202);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(775, 124);
            this.listBox2.TabIndex = 77;
            // 
            // KPE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.KPEText);
            this.Controls.Add(this.FormKPE);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.LoadUPK);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ReloadKPE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KPE";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label KPEText;
        private System.Windows.Forms.Button FormKPE;
        private System.Windows.Forms.Button LoadUPK;
        private System.Windows.Forms.Button ReloadKPE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}