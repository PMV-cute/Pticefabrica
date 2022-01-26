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
    public partial class Form2 : Form
    {
        public Form2()
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int value1) && int.TryParse(textBox2.Text, out int value2) && int.TryParse(textBox3.Text, out int value3))
            {
                label8.Text = new Logical().ReproductorLog(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), dateTimePicker1.Value);
            }
            else
            {
                if (label8.Text == "")
                    label8.Text = "Проверьте провильность введенных данных.";
                else label8.Text += ".";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reload();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null || listBox2.SelectedItem == null) { label9.Text = "выберите партию и/или инкубатор "; }
            else 
            {
                label9.Text = new Logical().IncubatorLoad(listBox1.SelectedItem.ToString(), listBox2.SelectedItem.ToString());
            }
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
                        listBox2.Items.Add($"{inc.ID}; Дата: {inc.DatePost}; Дата вылупления {inc.DayOfBorn};     Цикл закончен;");       
                    else
                        listBox2.Items.Add($"{inc.ID}; Дата: {inc.DatePost}; Дата вылупления {inc.DayOfBorn};     Цикл в процессе;");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox4.Text, out int value4) && int.TryParse(textBox5.Text, out int value5) && listBox2.SelectedItem != null && Convert.ToInt32(textBox4.Text)+Convert.ToInt32(textBox5.Text)<1001)
            {
                label9.Text = new Logical().IncubatorMolod(listBox2.SelectedItem.ToString(), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text));
            }
            else label9.Text = "Проверьте провильность введенных данных или выберите инкубатор";
            Reload();
        }
    }
}
