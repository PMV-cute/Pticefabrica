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
    public partial class CSE : Form
    {
        public CSE()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(MyForm_MouseDown);
            Reload();
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
        private void Reload()
        {
            listBox1.Items.Clear();

            ApplicationContext context = new ApplicationContext();
            var part = context.PartiyaEggs.ToList();
            foreach (var p in part)
            {
                if (p.FreeOrNotFree)
                {
                    listBox1.Items.Add($"{p.ID}; Дата: {p.DateForm}; Количество: {p.Kolvo};");
                }
            }
        }

        private void ReloadCSE_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void FormCSE_Click(object sender, EventArgs e)
        {
            ApplicationContext context = new ApplicationContext();
            if (listBox1.SelectedItem != null && int.TryParse(Category0.Text, out int value0) && int.TryParse(Category1.Text, out int value1) && int.TryParse(Category2.Text, out int value2) && int.TryParse(Category3.Text, out int value3) && int.TryParse(OtbrakovkaTextBox.Text, out int value4))
            {
                int[] a = new int[4] { Convert.ToInt32(Category0.Text), Convert.ToInt32(Category1.Text), Convert.ToInt32(Category2.Text), Convert.ToInt32(Category3.Text) };

                CSEText.Text = new Logical().CSEFormEgg(Convert.ToInt32(OtbrakovkaTextBox.Text), listBox1.SelectedItem.ToString(), a);

            }
            else { CSEText.Text = "Проверьте правильность введенных данных и/или выберите партию"; }
            Reload();
        }
    }
}
