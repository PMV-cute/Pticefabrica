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
            Form f1 = new Form1();
            f1.Show();
            Hide();
        }
        private void FormOtchet_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedItem != null && numericUpDown1 != null && numericUpDown2 != null)
            {
                string item = comboBox4.SelectedItem.ToString();
                int kvartal = (int)(numericUpDown1.Value);
                int year = (int)(numericUpDown2.Value);
                if (new Reporter().GetReport(year, kvartal, item))
                    OtchetLabel.Text = $"Отчет по \"{item}\" сформирован!";
                else OtchetLabel.Text = "Отчет не сформирован!";
            }
            else OtchetLabel.Text = "Проверьте правильность введенных данных";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ApplicationContext context = new ApplicationContext();
            List<Reproductor> a = context.Reproductor.ToList().OrderBy(o => o.RepID).ToList();
            List<ComplexProizvodstvaEggs> d = context.ComplexProizvodstvaEggs.ToList().OrderBy(o => o.ID).ToList();
            foreach (var aa in a)
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

        private void ReloadFunc1()
        {
            string item = comboBox1.SelectedItem.ToString();
            listBox1.Items.Clear();
            ApplicationContext context = new ApplicationContext();
            var asd = context.UPK.ToList();
            List<Reproductor> a = context.Reproductor.ToList().OrderBy(o => o.RepID).ToList();
            List<Incubator> b = context.Incubator.ToList().OrderBy(o => o.ID).ToList();
            List<Ptichnic> c = context.Ptichnic.ToList().OrderBy(o => o.ID).ToList();
            List<ComplexProizvodstvaEggs> d = context.ComplexProizvodstvaEggs.ToList().OrderBy(o => o.ID).ToList();
            if (item == "Репродуктор")
            {
                listBox1.Items.Add("Репродуктор: ");
                foreach (var ar in a)
                    listBox1.Items.Add($"{ar.RepID}; Бройлеры: {ar.KolvoB}; Несушки: {ar.KolvoN};");
            }
            if (item == "Инкубаторы")
            {
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
            }
            if (item == "Птичники")
            {
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
            }
            if (item == "Комплексы производства яиц")
            {
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
            }

            if (item == "УПК")
            {
                listBox1.Items.Add("Убойно перерабатывающий комплекс:");
                foreach (var u in asd)
                {
                    if (u.FreeOrNotFree)
                        listBox1.Items.Add($"Убойно перерабатывающий комплекс свободен");
                    else
                        listBox1.Items.Add($"Количество: {u.KolvoB}; Дата поступления {u.Dateform}");
                }
            }
        }
        private void Relaod1(object sender, EventArgs e)
        {
            ReloadFunc1();
        }

        private void CehBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null || comboBox1 == null)
            {
                ProductLabel.Text = "Выберите цех для очистки.";
                return;
            }
            string item = comboBox1.SelectedItem.ToString();
            string label = listBox1.SelectedItem.ToString();

            ApplicationContext context = new ApplicationContext();
            var asd = context.UPK.ToList();
            List<Reproductor> a = context.Reproductor.ToList().OrderBy(o => o.RepID).ToList();
            List<Incubator> b = context.Incubator.ToList().OrderBy(o => o.ID).ToList();
            List<Ptichnic> cas = context.Ptichnic.ToList().OrderBy(o => o.ID).ToList();
            List<ComplexProizvodstvaEggs> d = context.ComplexProizvodstvaEggs.ToList().OrderBy(o => o.ID).ToList();
            if (item == "Репродуктор")
            {
                foreach(var abs in a)
                {
                    abs.KolvoB = 0;
                    abs.KolvoN = 0;
                }
                context.SaveChanges();
            }
            if (item == "Инкубаторы")
            {
                label = label.Substring(0, label.IndexOf(";"));
                foreach (var inc in b)
                {
                    if (inc.ID.ToString() == label)
                    {
                        inc.KolvoEggs = 0;
                        inc.FreeOrNotFree = true;
                        inc.DatePost = DateTime.Now;
                        inc.DayOfBorn = DateTime.Now;
                        context.SaveChanges();
                    }
                }
            }
            if (item == "Птичники")
            {
                label = label.Substring(0, label.IndexOf(";"));
                foreach (var abs in cas)
                {
                    if (abs.ID.ToString() == label)
                    {
                        abs.Kolvo = 0;
                        abs.FreeOrNotFree = true;
                        abs.DatePost = DateTime.Now;
                        abs.DateGrow = DateTime.Now;
                        abs.TypeChicken = "";
                        context.SaveChanges();
                    }
                }
            }
            if (item == "Комплексы производства яиц")
            {
                label = label.Substring(0, label.IndexOf(";"));
                foreach (var abs in d)
                {
                    if (abs.ID.ToString() == label)
                    {
                        abs.KolvoN = 0;
                        abs.FreeOrNotFree = true;
                        abs.Pfeed = false;
                        abs.Pwater = false;
                        abs.Cikl = 0;
                        abs.DateForm = DateTime.Now;
                        context.SaveChanges();
                    }
                }
            }
            if (item == "УПК")
            {
                foreach (var abs in asd)
                {
                    abs.KolvoB = 0;
                    abs.FreeOrNotFree = true;
                    abs.Dateform = DateTime.Now;
                }
                context.SaveChanges();
            }
            if (item == "Инкубаторы" || item == "Птичники" || item == "Комплексы производства яиц")
                CehLabel.Text = $"{item} №{label} очищен.";
            else CehLabel.Text = $"{item} очищен.";
            ReloadFunc1();
        }
        private void ReloadFunc2()
        {
            string item = comboBox2.SelectedItem.ToString();

            listBox2.Items.Clear();

            ApplicationContext context = new ApplicationContext();
            List<Fabrikat> a = context.Fabrikat.ToList().OrderBy(o => o.ID).ToList();
            List<Melanj> b = context.Melanj.ToList().OrderBy(o => o.Ntari).ToList();
            List<PartiyaTovarnEggs> c = context.PartiyaTovarnEggs.ToList().OrderBy(o => o.ID).ToList();
            if (item == "Фабрикат")
            {
                listBox2.Items.Add("Фабрикат: ");
                foreach (var aa in a)
                {
                    listBox2.Items.Add($"{aa.ID}; Дата производства:{aa.DateUp}; Количество фабриката: {aa.kolvo}");
                }
            }
            if (item == "Меланж")
            {
                listBox2.Items.Add("Меланж: ");
                foreach (var bb in b)
                {
                    listBox2.Items.Add($"{bb.Ntari}; Дата:{bb.DateRosliva}; Тип: {bb.TypeMelanga}; Количество меланжа: {bb.kolvo}");
                }
            }
            if (item == "Партии товарных яиц")
            {
                listBox2.Items.Add("Партии товарных яиц: ");
                foreach (var cc in c)
                {
                    listBox2.Items.Add($"{cc.ID}; Дата:{cc.DateUp}; Категория {cc.Categori}; Количество яиц {cc.Kolvo};");
                }
            }
        }
        private void Reload2(object sender, EventArgs e)
        {
            ReloadFunc2();
        }
        private void ProdBtn_Click(object sender, EventArgs e)
        {
            ApplicationContext context = new ApplicationContext();
            if (listBox2.SelectedItem == null || comboBox2 == null)
            {
                ProductLabel.Text = "Выберите партию для удаления.";
                return;
            }
            string item = comboBox2.SelectedItem.ToString();
            string label = listBox2.SelectedItem.ToString();

            label = label.Substring(0, label.IndexOf(";"));

            List<Fabrikat> b = context.Fabrikat.ToList().OrderBy(o => o.ID).ToList();
            List<Melanj> a = context.Melanj.ToList().OrderBy(o => o.Ntari).ToList();
            List<PartiyaTovarnEggs> c = context.PartiyaTovarnEggs.ToList().OrderBy(o => o.ID).ToList();
            if (item == "Меланж")
            {
                foreach (var aa in a)
                {
                    if (aa.Ntari.ToString() == label)
                    {
                        context.Remove(context.Melanj.Single(s => s.Ntari == aa.Ntari)); // Удаление сущности из таблицы
                        context.SaveChanges();
                    }
                }
            }
            if (item == "Фабрикат")
            {
                foreach (var bb in b)
                {
                    if (bb.ID.ToString() == label)
                    {
                        context.Remove(context.Fabrikat.Single(s => s.ID == bb.ID)); // Удаление сущности из таблицы
                        context.SaveChanges();
                    }
                }
            }
            if (item == "Партии товарных яиц")
            {
                foreach (var cc in c)
                {
                    if (cc.ID.ToString() == label)
                    {
                        context.Remove(context.PartiyaTovarnEggs.Single(s => s.ID == cc.ID)); // Удаление сущности из таблицы
                        context.SaveChanges();
                    }
                }
            }
            ProductLabel.Text = $"{item} №{label} удален.";

            ReloadFunc2();
        }
        private void Reload3(object sender, EventArgs e)
        {
            string item = comboBox3.SelectedItem.ToString();
            listBox5.Items.Clear();
            ApplicationContext context = new ApplicationContext();
            List<PartiyaEggsRodClass> a = context.PartiyaEggsRodClass.ToList().OrderBy(o => o.ID).ToList();
            List<PartiyaMolodnyaka> b = context.PartiyaMolodnyaka.ToList().OrderBy(o => o.ID).ToList();
            List<PartiyaVzrosloyChicken> c = context.PartiyaVzrosloyChicken.ToList().OrderBy(o => o.ID).ToList();
            List<PartiyaEggs> d = context.PartiyaEggs.ToList().OrderBy(o => o.ID).ToList();
            if (item == "Партии яиц родительского стада")
            {
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
                    if (DateTime.Compare(date, date1) < 0 && parteg.FreeOrNotFree)
                    {
                        listBox5.Items.Add($"Просрочка {parteg.ID}; Дата: {parteg.DatePostEggs}; Количество: {parteg.Kolvo}; ");
                    }
                    if (!parteg.FreeOrNotFree)
                    {
                        listBox5.Items.Add($"Уже вылупились/Растут {parteg.ID}; Дата: {parteg.DatePostEggs}; Количество: {parteg.Kolvo}; ");
                    }
                }
            }
            if (item == "Партии молодняка")
            {
                listBox5.Items.Add("Партии молодняка: ");
                foreach (var partm in b)
                {
                    if (partm.PtID != null)
                    {
                        listBox5.Items.Add($"Растут/Выросли {partm.ID}; Дата: {partm.DataForm}; Количество: {partm.Kolvo}; {partm.TypeChicken}");
                    }
                    else
                    {
                        listBox5.Items.Add($"Еще не в птичнике {partm.ID}; Дата: {partm.DataForm}; Количество: {partm.Kolvo}; {partm.TypeChicken}");
                    }

                }
            }

            if (item == "Партии взрослой птицы")
            {
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
            }

            if (item == "Партии неотсортированных яиц")
            {
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
        }
    }
}