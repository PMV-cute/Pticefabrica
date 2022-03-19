
namespace Pticefabrica
{
    partial class UPK
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
            this.UPKText = new System.Windows.Forms.Label();
            this.FormUPK = new System.Windows.Forms.Button();
            this.LoadUPK = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ReloadUPK = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UPKLoad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UPKText
            // 
            this.UPKText.AutoSize = true;
            this.UPKText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UPKText.Location = new System.Drawing.Point(302, 323);
            this.UPKText.Name = "UPKText";
            this.UPKText.Size = new System.Drawing.Size(0, 21);
            this.UPKText.TabIndex = 70;
            // 
            // FormUPK
            // 
            this.FormUPK.Location = new System.Drawing.Point(12, 339);
            this.FormUPK.Name = "FormUPK";
            this.FormUPK.Size = new System.Drawing.Size(178, 23);
            this.FormUPK.TabIndex = 69;
            this.FormUPK.Text = "Сформировать фабрикат";
            this.FormUPK.UseVisualStyleBackColor = true;
            this.FormUPK.Click += new System.EventHandler(this.FormUPK_Click);
            // 
            // LoadUPK
            // 
            this.LoadUPK.Location = new System.Drawing.Point(12, 242);
            this.LoadUPK.Name = "LoadUPK";
            this.LoadUPK.Size = new System.Drawing.Size(178, 23);
            this.LoadUPK.TabIndex = 66;
            this.LoadUPK.Text = "Отправка в УПК";
            this.LoadUPK.UseVisualStyleBackColor = true;
            this.LoadUPK.Click += new System.EventHandler(this.LoadUPK_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 102);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(775, 124);
            this.listBox1.TabIndex = 65;
            // 
            // ReloadUPK
            // 
            this.ReloadUPK.Location = new System.Drawing.Point(12, 64);
            this.ReloadUPK.Name = "ReloadUPK";
            this.ReloadUPK.Size = new System.Drawing.Size(178, 23);
            this.ReloadUPK.TabIndex = 64;
            this.ReloadUPK.Text = "Обновить данные";
            this.ReloadUPK.UseVisualStyleBackColor = true;
            this.ReloadUPK.Click += new System.EventHandler(this.ReloadUPK_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Location = new System.Drawing.Point(773, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 15);
            this.label6.TabIndex = 63;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 62;
            this.label1.Text = "УПК";
            // 
            // UPKLoad
            // 
            this.UPKLoad.AutoSize = true;
            this.UPKLoad.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UPKLoad.Location = new System.Drawing.Point(12, 297);
            this.UPKLoad.Name = "UPKLoad";
            this.UPKLoad.Size = new System.Drawing.Size(0, 30);
            this.UPKLoad.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 73;
            this.label2.Text = "Статус УПК:";
            // 
            // UPK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UPKLoad);
            this.Controls.Add(this.UPKText);
            this.Controls.Add(this.FormUPK);
            this.Controls.Add(this.LoadUPK);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ReloadUPK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UPK";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UPKText;
        private System.Windows.Forms.Button FormUPK;
        private System.Windows.Forms.Button LoadUPK;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ReloadUPK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UPKLoad;
        private System.Windows.Forms.Label label2;
    }
}