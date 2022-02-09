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
    public partial class Form5 : Form
    {
        public Form5()
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
        private void label6_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReloadUPK_Click(object sender, EventArgs e)
        {
            Reload();
        }
        private void LoadUPK_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) { UPKText.Text = "выберите партию и/или УПК"; }
            else
            {
                UPKText.Text = new Logical().UPKLoad(listBox1.SelectedItem.ToString());
            }
            Reload();
        }
        private void FormUPK_Click(object sender, EventArgs e)
        {
            ApplicationContext context = new ApplicationContext();

            if (int.TryParse(textBox1.Text, out int value1))
            {
                UPK upk = context.UPK.FirstOrDefault();
                if (upk.KolvoB >= Convert.ToInt32(textBox1.Text))
                {
                    UPKText.Text = new Logical().UPKFormFabricat(Convert.ToInt32(textBox1.Text));
                }
                else { UPKText.Text = "Проверьте провильность введенных данных"; }
            }
            else UPKText.Text = "Проверьте провильность введенных данных";
            Reload();
        }
        public void Reload()
        {
            listBox1.Items.Clear();
            UPKLoad.Text = "";
            ApplicationContext context = new ApplicationContext();
            var part = context.PartiyaVzrosloyChicken.ToList();
            var upk = context.UPK.ToList();
            foreach (var parteg in part)
            {
                if (parteg.FreeOrNotFree == true && parteg.TypeChiсken == "Бройлер")
                {
                    listBox1.Items.Add($"{parteg.ID}; Дата: {parteg.DateForm}; Количество: {parteg.Kolvo};");
                }
                else
                {
                    if (parteg.TypeChiсken == "Бройлер")
                    {
                        context.Remove(context.PartiyaVzrosloyChicken.Single(s => s.ID == parteg.ID)); // Удаление сущности из таблицы
                        context.SaveChanges();
                    }
                    else { break; }
                }
            }
            foreach (var u in upk)
            {
                if (u.FreeOrNotFree)
                    UPKLoad.Text = $"Убойно перерабатывающий комплекс свободен";
                else
                    UPKLoad.Text = $"Количество: {u.KolvoB}; Дата поступления {u.Dateform}";
            }
        }
    }
}
