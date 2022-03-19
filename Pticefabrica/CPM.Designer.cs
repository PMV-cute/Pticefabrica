
namespace Pticefabrica
{
    partial class CPM
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
            this.CPMText = new System.Windows.Forms.Label();
            this.FormCPM = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ReloadCPM = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BelOKtextBox = new System.Windows.Forms.TextBox();
            this.JeltOKtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CPMText
            // 
            this.CPMText.AutoSize = true;
            this.CPMText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CPMText.Location = new System.Drawing.Point(253, 288);
            this.CPMText.Name = "CPMText";
            this.CPMText.Size = new System.Drawing.Size(0, 21);
            this.CPMText.TabIndex = 78;
            // 
            // FormCPM
            // 
            this.FormCPM.Location = new System.Drawing.Point(12, 286);
            this.FormCPM.Name = "FormCPM";
            this.FormCPM.Size = new System.Drawing.Size(222, 23);
            this.FormCPM.TabIndex = 77;
            this.FormCPM.Text = "Сформировать партию меланжа";
            this.FormCPM.UseVisualStyleBackColor = true;
            this.FormCPM.Click += new System.EventHandler(this.FormCPM_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 91);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(776, 124);
            this.listBox1.TabIndex = 74;
            // 
            // ReloadCPM
            // 
            this.ReloadCPM.Location = new System.Drawing.Point(12, 62);
            this.ReloadCPM.Name = "ReloadCPM";
            this.ReloadCPM.Size = new System.Drawing.Size(222, 23);
            this.ReloadCPM.TabIndex = 73;
            this.ReloadCPM.Text = "Обновить данные";
            this.ReloadCPM.UseVisualStyleBackColor = true;
            this.ReloadCPM.Click += new System.EventHandler(this.ReloadCPM_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Location = new System.Drawing.Point(773, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 15);
            this.label6.TabIndex = 72;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 15);
            this.label1.TabIndex = 71;
            this.label1.Text = "Цех производства меланжа";
            // 
            // BelOKtextBox
            // 
            this.BelOKtextBox.Location = new System.Drawing.Point(134, 257);
            this.BelOKtextBox.Name = "BelOKtextBox";
            this.BelOKtextBox.Size = new System.Drawing.Size(100, 23);
            this.BelOKtextBox.TabIndex = 79;
            // 
            // JeltOKtextBox
            // 
            this.JeltOKtextBox.Location = new System.Drawing.Point(134, 228);
            this.JeltOKtextBox.Name = "JeltOKtextBox";
            this.JeltOKtextBox.Size = new System.Drawing.Size(100, 23);
            this.JeltOKtextBox.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 81;
            this.label2.Text = "Количество белков";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 15);
            this.label3.TabIndex = 82;
            this.label3.Text = "Количество желков";
            // 
            // CPM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.JeltOKtextBox);
            this.Controls.Add(this.BelOKtextBox);
            this.Controls.Add(this.CPMText);
            this.Controls.Add(this.FormCPM);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ReloadCPM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CPM";
            this.Text = "Form8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CPMText;
        private System.Windows.Forms.Button FormCPM;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ReloadCPM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BelOKtextBox;
        private System.Windows.Forms.TextBox JeltOKtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}