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
            ApplicationContext context = new ApplicationContext();
            if (int.TryParse(textBox1.Text,out int value1) && int.TryParse(textBox2.Text, out int value2) && int.TryParse(textBox3.Text, out int value3) 
                                                           && int.TryParse(textBox4.Text, out int value4) && int.TryParse(textBox5.Text, out int value5))
            {
                Reproductor reproductor = context.Reproductor.FirstOrDefault();
                //Reproductor reproductor = context.Reproductor.Where(c => c.RepID == 1).FirstOrDefault();
                reproductor.KolvoB = Convert.ToInt32(textBox1.Text);
                reproductor.KolvoN = Convert.ToInt32(textBox2.Text);
                
                
                //context.Reproductor.Add(reproductor);
                var repr = context.Reproductor.ToList();
                for (int i = 0; i < Convert.ToInt32(textBox5.Text) / 1000; i++)
                {
                    PartiyaEggsRodClass partiyaEggsRodClass = new PartiyaEggsRodClass { 
                        Kolvo = 1000, 
                        RepID = repr[repr.Count-1].RepID, 
                        DatePostEggs = dateTimePicker1.Value 
                    };
                    context.PartiyaEggsRodClass.Add(partiyaEggsRodClass);
                    context.SaveChanges();
                }
                context.SaveChanges();

                //context.Reproductor.Update();
                var partrod = context.PartiyaEggsRodClass.ToList();
                var repr1 = context.Reproductor.ToList();
                label8.Text = $"{repr1[repr1.Count - 1].RepID};" +
                    $"{repr1[repr1.Count - 1].KolvoB};" +
                    $"{repr1[repr1.Count - 1].KolvoN};" +
                    $"{ partrod[partrod.Count - 1].DatePostEggs};";
                //label8.Text += reproductor.FormirovPartEggs();
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
            listBox1.Items.Clear();
            ApplicationContext context = new ApplicationContext();
            var parteggs = context.PartiyaEggsRodClass.ToList();

            foreach (var parteg in parteggs)
            {
                DateTime date = parteg.DatePostEggs;
                DateTime date1 = DateTime.Now;
                date1 = date1.AddDays(-3);
                if (DateTime.Compare(date,date1) >= 0) 
                {
                    listBox1.Items.Add($"{parteg.ID};        {parteg.DatePostEggs};        {parteg.Kolvo};");
                }
                    
            }
        }

    }
}
