using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using WinFormsLibrary1;
using WinFormsLibrary1.Entity;
using ApplicationContext = WinFormsLibrary1.ApplicationContext;
using System.Collections.Generic;
using System.Linq;

namespace Pticefabrica  // Репродуктор
{
    public partial class Form2 : Form
    {
        public Form2()
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int value1) && int.TryParse(textBox2.Text, out int value2) && int.TryParse(textBox3.Text, out int value3))
            {
                new Logical().ReproductorLog(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), dateTimePicker1.Value);
                ReproductorText.Text = "Готово!";
            }
            else
            {
                if (ReproductorText.Text == "")
                    ReproductorText.Text = "Проверьте провильность введенных данных.";
                else ReproductorText.Text += ".";
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            {
                Reload3();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox5.SelectedItem != null && listBox6.SelectedItem != null)
            {
                ReproductorText.Text = new Logical().ReprLoad(listBox5.SelectedItem.ToString(), listBox6.SelectedItem.ToString(), label5.Text, label6.Text);
            }
            else
            {
                ReproductorText.Text = "выберите партии";
            }
            Reload3();
        }

        //--------------------------------------------------------------------------------------------------

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
        //-----------------------------------------------------------------------------------------------
        private void ReloadPtichnic_Click(object sender, EventArgs e)
        {
            Reload2();
        }
        private void LoadPtichnic_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedItem == null || listBox4.SelectedItem == null) { PtichnicText.Text = "выберите партию и/или птичник "; }
            else
            {
                PtichnicText.Text = new Logical().PtichnicLoad(listBox3.SelectedItem.ToString(), listBox4.SelectedItem.ToString());
            }
            Reload2();
        }
        private void FormVzroslChicken_Click(object sender, EventArgs e)
        {
            new Logical().PtichnicFormPart(listBox4.SelectedItem.ToString());
            Reload2();
        }

        //----------------------------------------------------------------------------------------------


        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        //----------------------------------------------------------------------------------------------


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
                /*
                else
                {
                    context.Remove(context.PartiyaEggsRodClass.Single(s => s.ID == parteg.ID)); // Удаление сущности из таблицы
                    context.SaveChanges();
                }
                */
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
                        listBox2.Items.Add($"{inc.ID}; Дата поступления: {inc.DatePost}; Дата вылупления {inc.DayOfBorn};     Цикл закончен;");
                    else
                        listBox2.Items.Add($"{inc.ID}; Дата поступления: {inc.DatePost}; Дата вылупления {inc.DayOfBorn};     Цикл в процессе;");
                }
            }
        }
        public void Reload2()
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
                    /*
                    else
                    {
                        context.Remove(context.PartiyaMolodnyaka.Single(s => s.ID == partm.ID)); // Удаление сущности из таблицы
                        context.SaveChanges();
                    }
                    */
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
                        listBox4.Items.Add($"{p.ID}; Дата поступления: {p.DatePost}; Дата готовности {p.DateGrow}; {p.TypeChicken} - Взращивание закончено;");
                    else
                        listBox4.Items.Add($"{p.ID}; Дата поступления: {p.DatePost}; Дата готовности {p.DateGrow}; {p.TypeChicken} - Взращивание в процессе;");
                }
            }

        }
        public void Reload3()
        {
            listBox5.Items.Clear();
            listBox6.Items.Clear();

            ApplicationContext context = new ApplicationContext();
            Reproductor reproductor = context.Reproductor.FirstOrDefault();
            textBox1.Text = reproductor.KolvoB.ToString();
            textBox2.Text = reproductor.KolvoN.ToString();
            var parts = context.PartiyaVzrosloyChicken.ToList();
            foreach (var part in parts)
            {
                DateTime date = part.DateForm;
                DateTime date1 = DateTime.Now;
                date1 = date1.AddDays(-7);
                if (DateTime.Compare(date, date1) >= 0 && part.FreeOrNotFree && part.TypeChiсken == "Бройлер")
                {
                    listBox5.Items.Add($"{part.ID}; Количество: {part.Kolvo}; Бройлеры");
                }
                else
                {
                    if (DateTime.Compare(date, date1) >= 0 && part.FreeOrNotFree && part.TypeChiсken == "Несушка")
                    {
                        listBox6.Items.Add($"{part.ID}; Количество: {part.Kolvo}; Несушки");
                    }
                    else
                    {
                        context.SaveChanges();
                    }
                }
            }
        }


    }
}
