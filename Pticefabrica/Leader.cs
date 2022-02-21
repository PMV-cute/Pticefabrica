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
    public partial class Leader : Form
    {
        public Leader()
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

        private void Leader_Load(object sender, EventArgs e)
        {
            ApplicationContext context = new ApplicationContext();
            PartiyaEggsRodClass partiyaEggsRodClass = new PartiyaEggsRodClass();
            var parts = context.PartiyaEggsRodClass.ToList();
            dataGridView1.DataSource = parts;
            var parts1 = context.PartiyaMolodnyaka.ToList();
            dataGridView1.DataSource = parts1;
            
        }
    }
}
