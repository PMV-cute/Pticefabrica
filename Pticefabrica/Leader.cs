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
            Reload3();
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
            if (new Reporter().GetReport(year,kvartal))
                OtchetLabel.Text = "Все четко!";
            else OtchetLabel.Text = "Все не четко!";
        }

        private void ReloadData_Click(object sender, EventArgs e)
        {
            Reload1();
            Reload2();
            Reload3();
        }
        private void Reload3()
        {
            listBox5.Items.Clear();
            ApplicationContext context = new ApplicationContext();
            List<PartiyaEggsRodClass> a = context.PartiyaEggsRodClass.ToList().OrderBy(o => o.ID).ToList();
            List<PartiyaMolodnyaka> b = context.PartiyaMolodnyaka.ToList().OrderBy(o => o.ID).ToList();
            List<PartiyaVzrosloyChicken> c = context.PartiyaVzrosloyChicken.ToList().OrderBy(o => o.ID).ToList();
            List<PartiyaEggs> d = context.PartiyaEggs.ToList().OrderBy(o => o.ID).ToList();
            listBox5.Items.Add("Партии яиц родительского стада: ");
            foreach (var parteg in a)
            {
                DateTime date = parteg.DatePostEggs;
                DateTime date1 = DateTime.Now;
                date1 = date1.AddDays(-3);
                if (DateTime.Compare(date, date1) >= 0 && parteg.FreeOrNotFree)
                {
                    listBox5.Items.Add($"Ждут распределения {parteg.ID}; Дата: {parteg.DatePostEggs}; Количество: {parteg.Kolvo};");
                }
                if(DateTime.Compare(date,date1) < 0 && parteg.FreeOrNotFree)
                {
                    listBox5.Items.Add($"Просрочка {parteg.ID}; Дата: {parteg.DatePostEggs}; Количество: {parteg.Kolvo}; ");
                }
                if (!parteg.FreeOrNotFree)
                {
                    listBox5.Items.Add($"Уже вылупились/Растут {parteg.ID}; Дата: {parteg.DatePostEggs}; Количество: {parteg.Kolvo}; ");
                }
            }
            listBox5.Items.Add("");
            listBox5.Items.Add("Партии молодняка: ");
            foreach (var partm in b)
            {
                if (partm.PtID!=null)
                {
                    listBox5.Items.Add($"Растут/Выросли {partm.ID}; Дата: {partm.DataForm}; Количество: {partm.Kolvo}; {partm.TypeChicken}");
                }
                else
                {
                    listBox5.Items.Add($"Еще не в птичнике {partm.ID}; Дата: {partm.DataForm}; Количество: {partm.Kolvo}; {partm.TypeChicken}");
                }
                
            }
            listBox5.Items.Add("");
            listBox5.Items.Add("Партии взрослой птицы: ");
            foreach (var parteg in c)
            {
                if (parteg.FreeOrNotFree)
                {
                    listBox5.Items.Add($"Ждут распределения {parteg.ID}; Дата: {parteg.DateForm}; Количество: {parteg.Kolvo}; {parteg.TypeChiсken}");
                }
                else 
                {
                    listBox5.Items.Add($"Ушли в производство {parteg.ID}; Дата: {parteg.DateForm}; Количество: {parteg.Kolvo}; {parteg.TypeChiсken}");

                }
            }
            listBox5.Items.Add("");
            listBox5.Items.Add("Партии неотсортированных яиц: ");
            foreach (var p in d)
            {
                if (p.FreeOrNotFree)
                {
                    listBox5.Items.Add($"Готовы к сортировке {p.ID}; Дата: {p.DateForm}; Количество: {p.Kolvo};");
                }
                else
                {
                    listBox5.Items.Add($"Уже отсортированы {p.ID}; Дата: {p.DateForm}; Количество: {p.Kolvo};");

                }
            }
        }
        private void Reload2()
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            ApplicationContext context = new ApplicationContext();
            List<Fabrikat> a = context.Fabrikat.ToList().OrderBy(o => o.ID).ToList();
            List<Melanj> b = context.Melanj.ToList().OrderBy(o => o.Ntari).ToList();
            List<PartiyaTovarnEggs> c = context.PartiyaTovarnEggs.ToList().OrderBy(o => o.ID).ToList();
            listBox2.Items.Add("Фабрикат: ");
            foreach (var aa in a)
            {
                listBox2.Items.Add($"{aa.ID}; Дата производства: {aa.DateUp};");
            }
            listBox3.Items.Add("Меланж: ");
            foreach (var bb in b)
            {
                listBox3.Items.Add($"Номер тары: {bb.Ntari}; Дата: {bb.DateRosliva}; Тип: {bb.TypeMelanga};");
            }
            listBox4.Items.Add("Партии товарных яиц: ");
            foreach (var cc in c)
            {
                listBox4.Items.Add($"{cc.ID}; Количество {cc.Kolvo}; Категория {cc.Categori}; Дата {cc.DateUp}");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ApplicationContext context = new ApplicationContext();
            List<Reproductor> a = context.Reproductor.ToList().OrderBy(o => o.RepID).ToList();
            List<ComplexProizvodstvaEggs> d = context.ComplexProizvodstvaEggs.ToList().OrderBy(o => o.ID).ToList();
            foreach(var aa in a)
            {
                aa.maxB = (int)MaxKolvoB.Value;
                aa.maxN = (int)MaxKolvoN.Value;
                
            }
            context.SaveChanges();
            foreach (var dd in d)
            {
                dd.CiklMax = (int)MaxCikl.Value;
                context.SaveChanges();
            }
            OtchetLabel.Text = "Изменения готовы! ";
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
        }

        
    }
}
