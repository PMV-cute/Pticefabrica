using System;
using System.Windows.Forms;

namespace Pticefabrica
{
    public partial class Form3 : Form
    {
        public Form3()
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

        private void label6_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
