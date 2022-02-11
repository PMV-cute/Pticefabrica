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
    public partial class Form6 : Form
    {
        public Form6()
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
        private void ReloadKPE_Click(object sender, EventArgs e)
        {
            Reload();
        }
        private void LoadUPK_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null && listBox2.SelectedItem == null) { KPEText.Text = "выберите партию и/или комплекс"; }
            else
            {
                KPEText.Text = new Logical().CPYLoad(listBox1.SelectedItem.ToString(), listBox2.SelectedItem.ToString());
            }
            Reload();
        }

        private void FormKPE_Click(object sender, EventArgs e)
        {
            ApplicationContext context = new ApplicationContext();

            if (int.TryParse(textBox1.Text, out int value1))
            {
                KPEText.Text = new Logical().CPYFormEgg(Convert.ToInt32(textBox1.Text), listBox2.SelectedItem.ToString());
            }
            else KPEText.Text = "Проверьте провильность введенных данных";
            Reload();
        }
        public void Reload()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            ApplicationContext context = new ApplicationContext();
            var part = context.PartiyaVzrosloyChicken.ToList();
            var cpy = context.ComplexProizvodstvaEggs.ToList();
            foreach (var parteg in part)
            {
                if (parteg.FreeOrNotFree == true && parteg.TypeChiсken == "Несушка")
                {
                    listBox1.Items.Add($"{parteg.ID}; Дата: {parteg.DateForm}; Количество: {parteg.Kolvo};");
                }
                else
                {
                    /*
                    if (parteg.TypeChiсken == "Несушка")
                    {
                        context.Remove(context.PartiyaVzrosloyChicken.Single(s => s.ID == parteg.ID)); // Удаление сущности из таблицы
                        context.SaveChanges();
                    }
                    */

                    
                }
            }
            foreach (var u in cpy)
            {
                if (u.FreeOrNotFree)
                {
                    listBox2.Items.Add($"{u.ID};   Свободен;");
                }
                else
                {
                    listBox2.Items.Add($"{u.ID}; Дата поступления: {u.DateForm}; Количество: {u.KolvoN}");
                }
            }
        }

        
    }
}
