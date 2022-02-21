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
                Reload();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox5.SelectedItem != null && listBox6.SelectedItem != null)
            {
                ReproductorText.Text = new Logical().ReprLoad(listBox5.SelectedItem.ToString(), listBox6.SelectedItem.ToString());
            }
            else
            {
                ReproductorText.Text = "выберите партии";
            }
            Reload();
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void Reload()
        {
            listBox5.Items.Clear();
            listBox6.Items.Clear();

            ApplicationContext context = new ApplicationContext();
            Reproductor reproductor = context.Reproductor.FirstOrDefault();
            label5.Text = "Должно быть: " + reproductor.maxB;
            label6.Text = "Должно быть: " + reproductor.maxN;
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
