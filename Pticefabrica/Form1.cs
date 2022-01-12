﻿using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using WinFormsLibrary1;
using WinFormsLibrary1.Entity;
using ApplicationContext = WinFormsLibrary1.ApplicationContext;

namespace Pticefabrica
{
    public partial class Form1 : Form
    {
        Form f2 = new Form2();
        Form f3 = new Form3();
        public Form1()
        {
            new ApplicationContext(ApplicationContext.GetDb());
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(MyForm_MouseDown);
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
            var broyler = new Broyler 
            {
                TypeChiсken = "Broyler"
            };
            var CPO = new CehPererabotkiOthodov
            {
                NormsPererab = "132"
            };
            Context.Db.CehPererabotkiOthodov.Add(CPO);
            Context.Db.Broyler.Add(broyler); // Добавление данных в бд (Оно не обязательно для создания бд в первый раз)
            Context.Db.SaveChanges();

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
