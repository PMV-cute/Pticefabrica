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
    public partial class Form7 : Form
    {
        public Form7()
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
            Category0.Text = "0";
            Category1.Text = "0";
            Category2.Text = "0";
            Category3.Text = "0";

            ApplicationContext context = new ApplicationContext();
            var part = context.PartiyaEggs.ToList();
            foreach(var p in part)
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
            int[] a = new int[4] { Convert.ToInt32(Category0.Text), Convert.ToInt32(Category1.Text), Convert.ToInt32(Category2.Text), Convert.ToInt32(Category3.Text) };
            
            CSEText.Text = new Logical().CSEFormEgg(Convert.ToInt32(Melanjtextbox.Text), listBox1.SelectedItem.ToString(), a); 
        }
    }
}
