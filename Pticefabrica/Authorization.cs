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
    public partial class Form1 : Form
    {
        Form f2 = new Repr();
        Form f3 = new Incub();
        Form f4 = new Ptichnik();
        Form f5 = new UPK();
        Form f6 = new KPE();
        Form f7 = new CSE();
        Form f8 = new CPM();
        Form f9 = new Leader();
        public Form1()
        {
            new Create().CreateAll();
            new ApplicationContext();
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
            string log = textBox1.Text.ToString();
            string pas = textBox2.Text.ToString();
            
            
            ApplicationContext context = new ApplicationContext();
            var users = context.LogPas.ToList();
            int count = 0;
            foreach (var u in users)
            {
                count++;
                string upas = u.password;
                //textBox3.Text += u.login +u.password + u.role;
                if (u.login == log && new Crypt().getDeCrypt(pas,upas))
                {
                    if (u.role == "Репродуктор") f2.Show();
                    if (u.role == "Инкубатор") f3.Show();
                    if (u.role == "Птичник") f4.Show();
                    if (u.role == "УПК") f5.Show();
                    if (u.role == "КомплексПЯ") f6.Show();
                    if (u.role == "КомплексСЯ") f7.Show();
                    if (u.role == "ЦехПМ") f8.Show();
                    if (u.role == "Руководитель") f9.Show();
                    if (u.role == "Admin")
                    {
                        f2.Show();
                        f3.Show();
                        f4.Show();
                        f5.Show();
                        f6.Show();
                        f7.Show();
                        f8.Show();
                        f9.Show();
                    }
                    Hide();
                    return;
                }
                if(count == users.Count)
                {
                    label4.Text = "Неправильный логин или пароль";
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
