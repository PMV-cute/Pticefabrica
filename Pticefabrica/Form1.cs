using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsLibrary1;
using Npgsql;
using Microsoft.EntityFrameworkCore;
using ApplicationContext = WinFormsLibrary1.ApplicationContext;

namespace Pticefabrica
{
    public partial class Form1 : Form
    {
        Form f2 = new Form2();
        Form f3 = new Form3();
        public Form1()
        {
            //new ApplicationContext(ApplicationContext.GetDb());
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(MyForm_MouseDown);


            Broyler user1 = new Broyler { TypeChiсken = "Tom", ID = 1 };
            Broyler user2 = new Broyler { TypeChiсken = "Alice", ID = 2 };
            // using (ApplicationContext db = new ApplicationContext(ApplicationContext.GetDb()))
            //{
            //db.Broylers.AddRange(user1, user2);
            // db.SaveChanges();

            // }

            //Context.Db.Broylers.Add(user1);
            //Context.Db.SaveChanges();

            using (var context = new ApplicationContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();

                context.Broylers.Add(user2);
                // Saves changes
                context.SaveChanges();
            }
        }

        private void Form1_Load(object sender, EventArgs e) { }
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

            ConnectionBD connect = new ConnectionBD();
            connect.OpenConn();

            if (connect.GetConnect().State == ConnectionState.Open) //Проверка подключения к бд
                label5.Text = "Подключено";

            string role = "";
            using (NpgsqlCommand command = new NpgsqlCommand($"select role from users where login = '{log}' and password = '{pas}' ", connect.GetConnect()))
            {
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    role = reader.GetString(0);
                }
            }
            connect.CloseConn();
            if (role != "")
            {
                if (role == "Руководитель") f2.Show();
                if (role == "Рабочий") f3.Show();
                if (role == "Admin")
                {
                    f2.Show();
                    f3.Show();
                }

                Hide();
            }
            else
            {
                label4.Text = "Неправильный логин или пароль";
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
