﻿
namespace Pticefabrica
{
    partial class Form5
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
            this.button1 = new System.Windows.Forms.Button();
            this.LoadUPK = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ReloadUPK = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UPKLoad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UPKText
            // 
            this.UPKText.AutoSize = true;
            this.UPKText.Location = new System.Drawing.Point(328, 377);
            this.UPKText.Name = "UPKText";
            this.UPKText.Size = new System.Drawing.Size(0, 15);
            this.UPKText.TabIndex = 70;
            // 
            // FormUPK
            // 
            this.FormUPK.Location = new System.Drawing.Point(12, 362);
            this.FormUPK.Name = "FormUPK";
            this.FormUPK.Size = new System.Drawing.Size(178, 23);
            this.FormUPK.TabIndex = 69;
            this.FormUPK.Text = "Формирование фабриката";
            this.FormUPK.UseVisualStyleBackColor = true;
            this.FormUPK.Click += new System.EventHandler(this.FormUPK_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(559, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 23);
            this.button1.TabIndex = 68;
            this.button1.Text = "Утилизация";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LoadUPK
            // 
            this.LoadUPK.Location = new System.Drawing.Point(559, 126);
            this.LoadUPK.Name = "LoadUPK";
            this.LoadUPK.Size = new System.Drawing.Size(154, 23);
            this.LoadUPK.TabIndex = 66;
            this.LoadUPK.Text = "Отправка в УПК";
            this.LoadUPK.UseVisualStyleBackColor = true;
            this.LoadUPK.Click += new System.EventHandler(this.LoadUPK_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(519, 124);
            this.listBox1.TabIndex = 65;
            // 
            // ReloadUPK
            // 
            this.ReloadUPK.Location = new System.Drawing.Point(559, 85);
            this.ReloadUPK.Name = "ReloadUPK";
            this.ReloadUPK.Size = new System.Drawing.Size(154, 23);
            this.ReloadUPK.TabIndex = 64;
            this.ReloadUPK.Text = "Обновить";
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
            this.UPKLoad.Location = new System.Drawing.Point(12, 218);
            this.UPKLoad.Name = "UPKLoad";
            this.UPKLoad.Size = new System.Drawing.Size(0, 15);
            this.UPKLoad.TabIndex = 72;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UPKLoad);
            this.Controls.Add(this.UPKText);
            this.Controls.Add(this.FormUPK);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LoadUPK);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ReloadUPK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UPKText;
        private System.Windows.Forms.Button FormUPK;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button LoadUPK;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ReloadUPK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UPKLoad;
    }
}