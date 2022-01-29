using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using WinFormsLibrary1;
using WinFormsLibrary1.Entity;
using ApplicationContext = WinFormsLibrary1.ApplicationContext;
using System.Collections.Generic;
using System.Linq;

namespace WinFormsLibrary1
{
    public class Logical
    {
        public void ReproductorLog(int a, int b, int c, DateTime date) // Загрузка данных в репродуктор и создание родительских партий
        {
            ApplicationContext context = new ApplicationContext();

            Reproductor reproductor = context.Reproductor.FirstOrDefault();
            reproductor.KolvoB = a;
            reproductor.KolvoN = b;

            var repr = context.Reproductor.ToList();
            if (c > 0)
            {
                for (int i = 0; i < c / 1000; i++)
                {
                    PartiyaEggsRodClass partiyaEggsRodClass = new PartiyaEggsRodClass
                    {
                        Kolvo = 1000,
                        RepID = repr[repr.Count - 1].RepID,
                        DatePostEggs = date
                    };
                    context.PartiyaEggsRodClass.Add(partiyaEggsRodClass);
                    context.SaveChanges();
                }
                if (c%1000 != 0)
                {
                    PartiyaEggsRodClass partiyaEggsRodClass1 = new PartiyaEggsRodClass
                    {
                        Kolvo = c %1000,
                        RepID = repr[repr.Count - 1].RepID,
                        DatePostEggs = date
                    };
                    context.PartiyaEggsRodClass.Add(partiyaEggsRodClass1);
                }
                
                //PartiyaEggsRodClass partiyaEggsRodClass = context.PartiyaEggsRodClass.Where(h => h.ID == 1).FirstOrDefault(); //Удаление сущности из таблицы
                //context.PartiyaEggsRodClass.Remove(partiyaEggsRodClass);
                context.SaveChanges();
            }
            //context.Reproductor.Update();
        }
        public string ReprLoad(string a, string b, string e, string f)
        {
            ApplicationContext context = new ApplicationContext();
            int k = 0;
            k = a.IndexOf(";");
            a = a.Substring(0, k);

            k = b.IndexOf(";");
            b = b.Substring(0, k);

            k = e.IndexOf(":");

            e = e.Substring(k + 2);
            k = f.IndexOf(":");
            f = f.Substring(k + 2);

            int IDb = Convert.ToInt32(a);
            int IDn = Convert.ToInt32(b);
            int kolvob = Convert.ToInt32(e);
            int kolvon = Convert.ToInt32(f);
            PartiyaVzrosloyChicken partiyaVzrosloyChickenB = context.PartiyaVzrosloyChicken.Where(h => h.ID == IDb).FirstOrDefault();
            PartiyaVzrosloyChicken partiyaVzrosloyChickenN = context.PartiyaVzrosloyChicken.Where(h => h.ID == IDn).FirstOrDefault();

            Reproductor reproductor = context.Reproductor.FirstOrDefault();
            if (reproductor.KolvoB < kolvob || reproductor.KolvoN < kolvon)
            {
                partiyaVzrosloyChickenB.Kolvo += -(kolvob - reproductor.KolvoB);
                reproductor.KolvoB += (kolvob - reproductor.KolvoB);
                partiyaVzrosloyChickenN.Kolvo += -(kolvon - reproductor.KolvoN);
                reproductor.KolvoN += (kolvon - reproductor.KolvoN);
                context.SaveChanges();
                return "";
            }
            else 
            {
                return "Проверьте корректность выбора"; 
            }
        }
        

        public string IncubatorLoad(string a, string b) //Загрузка данных в инкубатор
        {
            ApplicationContext context = new ApplicationContext();
            int k = 0;
            k = a.IndexOf(";");
            a = a.Substring(0, k);
            k = b.IndexOf(";");
            b = b.Substring(0, k);
            int IDa = Convert.ToInt32(a);
            int IDb = Convert.ToInt32(b);
            PartiyaEggsRodClass partiyaEggsRodClass = context.PartiyaEggsRodClass.Where(h => h.ID == IDa).FirstOrDefault();
            Incubator incubator = context.Incubator.Where(c => c.ID == IDb).FirstOrDefault();
            if (incubator.FreeOrNotFree)
            {
                incubator.KolvoEggs = partiyaEggsRodClass.Kolvo;
                incubator.DatePost = DateTime.Now;
                incubator.DayOfBorn = partiyaEggsRodClass.DatePostEggs.AddDays(21);
                incubator.FreeOrNotFree = false;
                partiyaEggsRodClass.Kolvo = 0;
                partiyaEggsRodClass.FreeOrNotFree = false;
                partiyaEggsRodClass.IncID2 = incubator.ID;
                context.SaveChanges();
                return "";
            }
            else { return "Инкубатор заполнен"; }
        }
        public string IncubatorMolod(string a, int b, int c) // Создание партии молодняка из вылупившихся яиц в инкубаторе
        {
            ApplicationContext context = new ApplicationContext();

            int k = a.IndexOf(";");
            a = a.Substring(0, k);
            int IDb = Convert.ToInt32(a);
            Incubator incubator = context.Incubator.Where(c => c.ID == IDb).FirstOrDefault();
            if (DateTime.Compare(DateTime.Now, incubator.DayOfBorn) > 0)
            {
                PartiyaMolodnyaka partiyaMolodnyaka = new PartiyaMolodnyaka
                {
                    TypeChicken = "Бройлер",
                    Kolvo = b,
                    IncID = incubator.ID,
                    DataForm = DateTime.Now,
                };
                PartiyaMolodnyaka partiyaMolodnyaka1 = new PartiyaMolodnyaka
                {
                    TypeChicken = "Несушка",
                    Kolvo = c,
                    IncID = incubator.ID,
                    DataForm = DateTime.Now,
                };
                context.PartiyaMolodnyaka.AddRange(partiyaMolodnyaka, partiyaMolodnyaka1);
                incubator.FreeOrNotFree = true;
                incubator.DayOfBorn = DateTime.Now.AddYears(100);
                incubator.KolvoEggs = 0;
                context.SaveChanges();
                return "";
            }
            else { return "Яйца не вылупились"; }
        }
        public string PtichnicLoad(string a, string b)
        {
            ApplicationContext context = new ApplicationContext();
            int k = 0;
            k = a.IndexOf(";");
            a = a.Substring(0, k);
            k = b.IndexOf(";");
            b = b.Substring(0, k);
            int IDa = Convert.ToInt32(a);
            int IDb = Convert.ToInt32(b);
            PartiyaMolodnyaka partiyaMolodnyaka = context.PartiyaMolodnyaka.Where(h => h.ID == IDa).FirstOrDefault();
            Ptichnic ptichnic = context.Ptichnic.Where(c => c.ID == IDb).FirstOrDefault();
            int days = 60;
            if (partiyaMolodnyaka.TypeChicken == "Бройлер")
                days = 20;
            else
                days = 60;
            if (ptichnic.FreeOrNotFree)
            {
                ptichnic.Kolvo = partiyaMolodnyaka.Kolvo;
                ptichnic.DatePost = DateTime.Now;
                ptichnic.DateGrow = partiyaMolodnyaka.DataForm.AddDays(days);
                ptichnic.FreeOrNotFree = false;
                ptichnic.TypeChicken = partiyaMolodnyaka.TypeChicken;
                partiyaMolodnyaka.Kolvo = 0;
                partiyaMolodnyaka.FreeOrNotFree = false;
                partiyaMolodnyaka.PtID = ptichnic.ID;
                context.SaveChanges();
                return "";
            }
            else { return "Птичник заполнен"; }
        }

        public string PtichnicFormPart(string a) // Создание партии взрослой птицы из птенцов птичника
        {
            ApplicationContext context = new ApplicationContext();

            int k = a.IndexOf(";");
            a = a.Substring(0, k);
            int IDb = Convert.ToInt32(a);
            Ptichnic ptichnic = context.Ptichnic.Where(c => c.ID == IDb).FirstOrDefault();
            if (DateTime.Compare(DateTime.Now, ptichnic.DateGrow) > 0)
            {
                PartiyaVzrosloyChicken partiyaVzrosloyChicken = new PartiyaVzrosloyChicken
                {
                    TypeChiсken = ptichnic.TypeChicken,
                    Kolvo = ptichnic.Kolvo,
                    PtID2 = ptichnic.ID,
                    DateForm = DateTime.Now,
                };
                context.PartiyaVzrosloyChicken.Add(partiyaVzrosloyChicken);
                ptichnic.FreeOrNotFree = true;
                ptichnic.DateGrow = DateTime.Now.AddYears(100);
                ptichnic.Kolvo = 0;
                ptichnic.TypeChicken = "";
                context.SaveChanges();
                return "";
            }
            else { return "Птицы не выросли"; }
        }
    }
}
