using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using WinFormsLibrary1;
using WinFormsLibrary1.Entity;
using ApplicationContext = WinFormsLibrary1.ApplicationContext;
using System.Collections.Generic;
using System.Linq;

namespace Pticefabrica // Инкубатор
{
    public partial class Form3 : Form
    {
        public Form3()
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

        private void ReloadInc_Click(object sender, EventArgs e)
        {
            Reload();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null || listBox2.SelectedItem == null) { IncubatorText.Text = "выберите партию и/или инкубатор "; }
            else
            {
                IncubatorText.Text = new Logical().IncubatorLoad(listBox1.SelectedItem.ToString(), listBox2.SelectedItem.ToString());
            }
            Reload();
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ApplicationContext context = new ApplicationContext();

            if (int.TryParse(textBox4.Text, out int value4) && int.TryParse(textBox5.Text, out int value5) && listBox2.SelectedItem != null && Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text) < 1001)
            {
                int k = listBox2.SelectedItem.ToString().IndexOf(";");
                int IDb = Convert.ToInt32(listBox2.SelectedItem.ToString().Substring(0, k));
                Incubator incubator = context.Incubator.Where(c => c.ID == IDb).FirstOrDefault();
                if (incubator.KolvoEggs >= Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text))
                {
                    IncubatorText.Text = new Logical().IncubatorMolod(listBox2.SelectedItem.ToString(), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text));
                }
            }
            else IncubatorText.Text = "Проверьте провильность введенных данных или выберите инкубатор";
            Reload();
        }

        public void Reload()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            ApplicationContext context = new ApplicationContext();
            var parteggs = context.PartiyaEggsRodClass.ToList();
            var incub = context.Incubator.ToList();
            foreach (var parteg in parteggs)
            {
                DateTime date = parteg.DatePostEggs;
                DateTime date1 = DateTime.Now;
                date1 = date1.AddDays(-3);
                if (DateTime.Compare(date, date1) >= 0 && parteg.FreeOrNotFree)
                {
                    listBox1.Items.Add($"{parteg.ID}; Дата: {parteg.DatePostEggs}; Количество: {parteg.Kolvo};");
                }
                else
                {
                    context.Remove(context.PartiyaEggsRodClass.Single(s => s.ID == parteg.ID)); // Удаление сущности из таблицы
                    context.SaveChanges();
                }
            }
            foreach (var inc in incub)
            {
                if (inc.FreeOrNotFree)
                {
                    listBox2.Items.Add($"{inc.ID};   Свободен;");
                }
                else
                {
                    if (DateTime.Compare(DateTime.Now, inc.DayOfBorn) >= 0)
                        listBox2.Items.Add($"{inc.ID}; Дата поступления: {inc.DatePost}; Дата вылупления {inc.DayOfBorn}; Количество {inc.KolvoEggs}. Цикл закончен;");
                    else
                        listBox2.Items.Add($"{inc.ID}; Дата поступления: {inc.DatePost}; Дата вылупления {inc.DayOfBorn}; Количество {inc.KolvoEggs}. Цикл в процессе;");
                }
            }
        }
    }
}
