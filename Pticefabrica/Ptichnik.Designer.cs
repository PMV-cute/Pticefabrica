
namespace Pticefabrica
{
    partial class Ptichnik
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
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PtichnicText = new System.Windows.Forms.Label();
            this.FormVzroslChicken = new System.Windows.Forms.Button();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.LoadPtichnic = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.ReloadPtichnic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Птичник";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Location = new System.Drawing.Point(773, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // PtichnicText
            // 
            this.PtichnicText.AutoSize = true;
            this.PtichnicText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PtichnicText.Location = new System.Drawing.Point(240, 388);
            this.PtichnicText.Name = "PtichnicText";
            this.PtichnicText.Size = new System.Drawing.Size(0, 21);
            this.PtichnicText.TabIndex = 61;
            // 
            // FormVzroslChicken
            // 
            this.FormVzroslChicken.Location = new System.Drawing.Point(12, 389);
            this.FormVzroslChicken.Name = "FormVzroslChicken";
            this.FormVzroslChicken.Size = new System.Drawing.Size(242, 23);
            this.FormVzroslChicken.TabIndex = 60;
            this.FormVzroslChicken.Text = "Сформировать партию взрослой птицы";
            this.FormVzroslChicken.UseVisualStyleBackColor = true;
            this.FormVzroslChicken.Click += new System.EventHandler(this.FormVzroslChicken_Click);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 15;
            this.listBox4.Location = new System.Drawing.Point(12, 200);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(775, 124);
            this.listBox4.TabIndex = 58;
            // 
            // LoadPtichnic
            // 
            this.LoadPtichnic.Location = new System.Drawing.Point(12, 341);
            this.LoadPtichnic.Name = "LoadPtichnic";
            this.LoadPtichnic.Size = new System.Drawing.Size(242, 23);
            this.LoadPtichnic.TabIndex = 57;
            this.LoadPtichnic.Text = "Добавить партию птиц в птичник";
            this.LoadPtichnic.UseVisualStyleBackColor = true;
            this.LoadPtichnic.Click += new System.EventHandler(this.LoadPtichnic_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 15;
            this.listBox3.Location = new System.Drawing.Point(12, 70);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(775, 124);
            this.listBox3.TabIndex = 56;
            // 
            // ReloadPtichnic
            // 
            this.ReloadPtichnic.Location = new System.Drawing.Point(12, 41);
            this.ReloadPtichnic.Name = "ReloadPtichnic";
            this.ReloadPtichnic.Size = new System.Drawing.Size(215, 23);
            this.ReloadPtichnic.TabIndex = 55;
            this.ReloadPtichnic.Text = "Обновить данные";
            this.ReloadPtichnic.UseVisualStyleBackColor = true;
            this.ReloadPtichnic.Click += new System.EventHandler(this.ReloadPtichnic_Click);
            // 
            // Ptichnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PtichnicText);
            this.Controls.Add(this.FormVzroslChicken);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.LoadPtichnic);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.ReloadPtichnic);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ptichnik";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label PtichnicText;
        private System.Windows.Forms.Button FormVzroslChicken;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Button LoadPtichnic;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button ReloadPtichnic;
    }
}