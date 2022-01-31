using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using WinFormsLibrary1;
using WinFormsLibrary1.Entity;
using ApplicationContext = WinFormsLibrary1.ApplicationContext;
using System.Collections.Generic;
using System.Linq;

namespace Pticefabrica  // Птичник
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(MyForm_MouseDown);

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
        private void ReloadPtichnic_Click(object sender, EventArgs e)
        {
            Reload();
        }
        private void LoadPtichnic_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedItem == null || listBox4.SelectedItem == null) { PtichnicText.Text = "выберите партию и/или птичник "; }
            else
            {
                PtichnicText.Text = new Logical().PtichnicLoad(listBox3.SelectedItem.ToString(), listBox4.SelectedItem.ToString());
            }
            Reload();
        }

        private void FormVzroslChicken_Click(object sender, EventArgs e)
        {
            if (listBox4.SelectedItem != null)
            {
                new Logical().PtichnicFormPart(listBox4.SelectedItem.ToString());
            }
           
            Reload();
        }
        public void Reload()
        {
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            ApplicationContext context = new ApplicationContext();
            var partms = context.PartiyaMolodnyaka.ToList();
            var pt = context.Ptichnic.ToList();
            foreach (var partm in partms)
            {
                DateTime date = partm.DataForm;
                DateTime date1 = DateTime.Now;
                date1 = date1.AddDays(-1);
                if (DateTime.Compare(date, date1) >= 0 && partm.FreeOrNotFree && partm.TypeChicken == "Бройлер")
                {
                    listBox3.Items.Add($"{partm.ID}; Дата: {partm.DataForm}; Количество: {partm.Kolvo}; Бройлеры");
                }
                else
                {
                    if (DateTime.Compare(date, date1) >= 0 && partm.FreeOrNotFree && partm.TypeChicken == "Несушка")
                    {
                        listBox3.Items.Add($"{partm.ID}; Дата: {partm.DataForm}; Количество: {partm.Kolvo}; Несушки");
                    }
                    else
                    {
                        context.Remove(context.PartiyaMolodnyaka.Single(s => s.ID == partm.ID)); // Удаление сущности из таблицы
                        context.SaveChanges();
                    }
                }
            }

            foreach (var p in pt)
            {
                if (p.FreeOrNotFree)
                {
                    listBox4.Items.Add($"{p.ID};   Свободен;");
                }
                else
                {
                    if (DateTime.Compare(DateTime.Now, p.DateGrow) >= 0)
                        listBox4.Items.Add($"{p.ID}; Дата поступления: {p.DatePost}; Дата готовности {p.DateGrow}; Количество {p.Kolvo}, {p.TypeChicken} - Взращивание закончено; ");
                    else
                        listBox4.Items.Add($"{p.ID}; Дата поступления: {p.DatePost}; Дата готовности {p.DateGrow}; Количество {p.Kolvo}, {p.TypeChicken} - Взращивание в процессе;");
                }
            }

        }

        
    }
}
