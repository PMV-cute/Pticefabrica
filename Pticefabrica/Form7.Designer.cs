
namespace Pticefabrica
{
    partial class Form7
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
            this.label2 = new System.Windows.Forms.Label();
            this.Category1 = new System.Windows.Forms.TextBox();
            this.CSEText = new System.Windows.Forms.Label();
            this.FormCSE = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ReloadCSE = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Category2 = new System.Windows.Forms.TextBox();
            this.Category3 = new System.Windows.Forms.TextBox();
            this.Category0 = new System.Windows.Forms.TextBox();
            this.Melanjtextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 94;
            this.label2.Text = "Категории";
            // 
            // Category1
            // 
            this.Category1.Location = new System.Drawing.Point(180, 348);
            this.Category1.Name = "Category1";
            this.Category1.Size = new System.Drawing.Size(100, 23);
            this.Category1.TabIndex = 93;
            // 
            // CSEText
            // 
            this.CSEText.AutoSize = true;
            this.CSEText.Location = new System.Drawing.Point(257, 381);
            this.CSEText.Name = "CSEText";
            this.CSEText.Size = new System.Drawing.Size(43, 15);
            this.CSEText.TabIndex = 92;
            this.CSEText.Text = "asdasd";
            // 
            // FormCSE
            // 
            this.FormCSE.Location = new System.Drawing.Point(13, 377);
            this.FormCSE.Name = "FormCSE";
            this.FormCSE.Size = new System.Drawing.Size(201, 23);
            this.FormCSE.TabIndex = 91;
            this.FormCSE.Text = "Формирование товарных яиц";
            this.FormCSE.UseVisualStyleBackColor = true;
            this.FormCSE.Click += new System.EventHandler(this.FormCSE_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(13, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(519, 124);
            this.listBox1.TabIndex = 87;
            // 
            // ReloadCSE
            // 
            this.ReloadCSE.Location = new System.Drawing.Point(560, 100);
            this.ReloadCSE.Name = "ReloadCSE";
            this.ReloadCSE.Size = new System.Drawing.Size(154, 23);
            this.ReloadCSE.TabIndex = 86;
            this.ReloadCSE.Text = "Обновить";
            this.ReloadCSE.UseVisualStyleBackColor = true;
            this.ReloadCSE.Click += new System.EventHandler(this.ReloadCSE_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Location = new System.Drawing.Point(774, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 15);
            this.label6.TabIndex = 85;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 84;
            this.label1.Text = "Цех сортировки яиц";
            // 
            // Category2
            // 
            this.Category2.Location = new System.Drawing.Point(286, 349);
            this.Category2.Name = "Category2";
            this.Category2.Size = new System.Drawing.Size(100, 23);
            this.Category2.TabIndex = 96;
            // 
            // Category3
            // 
            this.Category3.Location = new System.Drawing.Point(392, 349);
            this.Category3.Name = "Category3";
            this.Category3.Size = new System.Drawing.Size(100, 23);
            this.Category3.TabIndex = 97;
            // 
            // Category0
            // 
            this.Category0.Location = new System.Drawing.Point(74, 348);
            this.Category0.Name = "Category0";
            this.Category0.Size = new System.Drawing.Size(100, 23);
            this.Category0.TabIndex = 98;
            // 
            // Melanjtextbox
            // 
            this.Melanjtextbox.Location = new System.Drawing.Point(74, 289);
            this.Melanjtextbox.Name = "Melanjtextbox";
            this.Melanjtextbox.Size = new System.Drawing.Size(100, 23);
            this.Melanjtextbox.TabIndex = 99;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Melanjtextbox);
            this.Controls.Add(this.Category0);
            this.Controls.Add(this.Category3);
            this.Controls.Add(this.Category2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Category1);
            this.Controls.Add(this.CSEText);
            this.Controls.Add(this.FormCSE);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ReloadCSE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Category1;
        private System.Windows.Forms.Label CSEText;
        private System.Windows.Forms.Button FormCSE;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ReloadCSE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Category2;
        private System.Windows.Forms.TextBox Category3;
        private System.Windows.Forms.TextBox Category0;
        private System.Windows.Forms.TextBox Melanjtextbox;
    }
}