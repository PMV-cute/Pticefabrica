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
                Reproductor reproductor = new Reproductor
                {
                    KolvoB = Convert.ToInt32(textBox1.Text),
                    KolvoN = Convert.ToInt32(textBox2.Text),
                    feed = Convert.ToInt32(textBox3.Text),
                    water = Convert.ToInt32(textBox4.Text),
                    DateP = dateTimePicker1.Text
                };
                
                context.Reproductor.Add(reproductor);
                var repr = context.Reproductor.ToList();
                for (int i = 0; i < Convert.ToInt32(textBox5.Text) / 10000 - 1; i++)
                {
                    PartiyaEggsRodClass partiyaEggsRodClass = new PartiyaEggsRodClass { Kolvo = 10000, RepID = repr[repr.Count].RepID };
                    context.PartiyaEggsRodClass.Add(partiyaEggsRodClass);
                }
                context.SaveChanges();
                /*
                using (var db = new ApplicationContext())
                {
                    var result = db.Reproductor.SingleOrDefault(b => b.KolvoB == 100);
                    if (result != null)
                    {
                        result.KolvoB = 12;
                        db.SaveChanges();
                    }
                }
                */
                //context.Reproductor.Update();
                var repr1 = context.Reproductor.ToList();
                label8.Text = $"{repr1[repr1.Count-1].RepID};{repr1[repr1.Count-1].KolvoB};{repr1[repr1.Count-1].KolvoN};{ repr1[repr1.Count-1].DateP};{repr1[repr1.Count-1].feed};{repr1[repr1.Count-1].water};";
                //label8.Text += reproductor.FormirovPartEggs();
            }
            else
            {
                if (label8.Text == "")
                    label8.Text = "Проверьте провильность введенных данных.";
                else label8.Text += ".";
            }
            
        }
    }
}
