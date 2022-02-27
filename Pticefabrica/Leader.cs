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
            Reload1();
            Reload2();

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
        private void FormOtchet_Click(object sender, EventArgs e)
        {
            int kvartal = (int)(numericUpDown1.Value);
            int year = (int)(numericUpDown2.Value);
            if (new Reporter().GetReport())
                OtchetLabel.Text = "Все четко!";
            else OtchetLabel.Text = "Все не четко!";
        }

        private void ReloadData_Click(object sender, EventArgs e)
        {
            Reload1();
            Reload2();
        }
        private void Reload2()
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            ApplicationContext context = new ApplicationContext();
            List<Fabrikat> a = context.Fabrikat.ToList().OrderBy(o => o.ID).ToList();
            List<Melanj> b = context.Melanj.ToList().OrderBy(o => o.Ntari).ToList();
            List<PartiyaTovarnEggs> c = context.PartiyaTovarnEggs.ToList().OrderBy(o => o.ID).ToList();
            listBox2.Items.Add("Фабрикат: ");
            foreach (var af in a)
            {
                listBox2.Items.Add($"Количество: {af.Kolvo}; Дата производства: {af.DateUp};");
            }
            foreach (var bm in b)
            {
                listBox3.Items.Add($"Номер тары: {bm.Ntari}; Дата: {bm.DateRosliva}; Тип: {bm.TypeMelanga};");
            }

        }
        private void Reload1()
        {
            listBox1.Items.Clear();
            ApplicationContext context = new ApplicationContext();
            var e = context.UPK.ToList();
            List<Reproductor> a = context.Reproductor.ToList().OrderBy(o => o.RepID).ToList();
            List<Incubator> b = context.Incubator.ToList().OrderBy(o => o.ID).ToList();
            List<Ptichnic> c = context.Ptichnic.ToList().OrderBy(o => o.ID).ToList();
            List<ComplexProizvodstvaEggs> d = context.ComplexProizvodstvaEggs.ToList().OrderBy(o => o.ID).ToList();
           
            foreach (var ar in a)
                listBox1.Items.Add($"Репродуктор: {ar.RepID}; Бройлеры: {ar.KolvoB}; Несушки: {ar.KolvoN};");

            listBox1.Items.Add("");
            listBox1.Items.Add("Инкубаторы: ");
            foreach (var inc in b)
            {
                if (inc.FreeOrNotFree)
                {
                    listBox1.Items.Add($"{inc.ID};   Свободен;");
                }
                else
                {
                    if (DateTime.Compare(DateTime.Now, inc.DayOfBorn) >= 0)
                        listBox1.Items.Add($"{inc.ID}; Дата поступления: {inc.DatePost}; Дата вылупления {inc.DayOfBorn}; Количество {inc.KolvoEggs}. Цикл закончен;");
                    else
                        listBox1.Items.Add($"{inc.ID}; Дата поступления: {inc.DatePost}; Дата вылупления {inc.DayOfBorn}; Количество {inc.KolvoEggs}. Цикл в процессе;");
                }
            }
            listBox1.Items.Add("");
            listBox1.Items.Add("Птичники: ");
            foreach (var p in c)
            {
                if (p.FreeOrNotFree)
                {
                    listBox1.Items.Add($"{p.ID};   Свободен;");
                }
                else
                {
                    if (DateTime.Compare(DateTime.Now, p.DateGrow) >= 0)
                        listBox1.Items.Add($"{p.ID}; Дата поступления: {p.DatePost}; Дата готовности {p.DateGrow}; Количество {p.Kolvo}, {p.TypeChicken} - Взращивание закончено; ");
                    else
                        listBox1.Items.Add($"{p.ID}; Дата поступления: {p.DatePost}; Дата готовности {p.DateGrow}; Количество {p.Kolvo}, {p.TypeChicken} - Взращивание в процессе;");
                }
            }
            listBox1.Items.Add("");
            listBox1.Items.Add("Комплексы производства яиц: ");
            foreach (var u in d)
            {
                if (u.FreeOrNotFree)
                {
                    listBox1.Items.Add($"{u.ID};   Свободен;");
                }
                else
                {
                    listBox1.Items.Add($"{u.ID}; Дата поступления: {u.DateForm}; Количество: {u.KolvoN}; Цикл: №{u.Cikl + 1}");
                }
            }
            listBox1.Items.Add("");
            listBox1.Items.Add("Убойно перерабатывающий комплекс:");
            foreach (var u in e)
            {
                if (u.FreeOrNotFree)
                    listBox1.Items.Add($"Убойно перерабатывающий комплекс свободен");
                else
                    listBox1.Items.Add($"Количество: {u.KolvoB}; Дата поступления {u.Dateform}");
            }
            /*
            DataGridViewTextBoxColumn col0 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
            col0.HeaderText = "Номер";
            col1.HeaderText = "Количество";
            col3.HeaderText = "Дата рождения";
            col4.HeaderText = "Связанный репродуктор";
            col5.HeaderText = "Связанный инкубатор";
            col2.HeaderText = "FreeOrNotFree";
            col0.Name = "Номер";
            col1.Name = "Количество";
            col2.Name = "FreeOrNotFree";
            col3.Name = "Дата рождения";
            col4.Name = "Связанный репродуктор";
            col5.Name = "Связанный инкубатор";
            Part1Data.Columns.Add(col0);
            Part1Data.Columns.Add(col1);
            Part1Data.Columns.Add(col2);
            Part1Data.Columns.Add(col3);
            Part1Data.Columns.Add(col4);
            Part1Data.Columns.Add(col5);
            for (int i = 0; i < 1; i++)
            {
                DataGridViewCell firstCell = new DataGridViewTextBoxCell();
                DataGridViewCell secondCell = new DataGridViewTextBoxCell(); 
                DataGridViewCell thirdCell = new DataGridViewCheckBoxCell();
                DataGridViewCell fourthCell = new DataGridViewCheckBoxCell();
                DataGridViewCell fifthCell = new DataGridViewCheckBoxCell();
                DataGridViewCell sixCell = new DataGridViewCheckBoxCell();
                DataGridViewRow row = new DataGridViewRow();
                firstCell.Value = Convert.ToString(a[i].ID);
                secondCell.Value = Convert.ToString(a[i].Kolvo);
                thirdCell.Value  = Convert.ToString(a[i].FreeOrNotFree);
                fourthCell.Value = Convert.ToString(a[i].DatePostEggs);
                fifthCell.Value =  Convert.ToString(a[i].RepID);
                sixCell.Value = Convert.ToString(a[i].IncID2);

                row.Cells.AddRange(firstCell, secondCell, thirdCell, fourthCell, fifthCell, sixCell);
                Part1Data.Rows.Add(row);
                
            }
            */
        }


    }
}
