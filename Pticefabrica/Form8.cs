using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using WinFormsLibrary1;
using WinFormsLibrary1.Entity;
using ApplicationContext = WinFormsLibrary1.ApplicationContext;
using System.Collections.Generic;
using System.Linq;

namespace Pticefabrica
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(MyForm_MouseDown);
            Reload();
        }

        private void ReloadCPM_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void FormCPM_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null && int.TryParse(BelOKtextBox.Text, out int value0) && int.TryParse(JeltOKtextBox.Text, out int value1))
            {
                CPMText.Text = new Logical().CPMFormMelanj(Convert.ToInt32(BelOKtextBox.Text), Convert.ToInt32(JeltOKtextBox.Text), listBox1.SelectedItem.ToString());
            }
            else { CPMText.Text = "Проверьте правильность введенных данных и/или выберите партию"; }
            Reload();
        }
        private void Reload()
        {
            listBox1.Items.Clear();

            ApplicationContext context = new ApplicationContext();
            var part = context.OtbrakovkaEggs.ToList();
            foreach (var p in part)
            {
                if (p.FreeOrNotFree)
                {
                    listBox1.Items.Add($"{p.ID}; Дата: {p.dateTime}; Количество: {p.kolvo};");
                }
            }
        }

        private void MyForm_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
