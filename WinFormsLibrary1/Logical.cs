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
                        DatePostEggs = date,
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
        public string ReprLoad(string a, string b)
        {
            ApplicationContext context = new ApplicationContext();
            int k = 0;
            k = a.IndexOf(";");
            a = a.Substring(0, k);

            k = b.IndexOf(";");
            b = b.Substring(0, k);
            int IDb = Convert.ToInt32(a);
            int IDn = Convert.ToInt32(b);
            
            PartiyaVzrosloyChicken partiyaVzrosloyChickenB = context.PartiyaVzrosloyChicken.Where(h => h.ID == IDb).FirstOrDefault();
            PartiyaVzrosloyChicken partiyaVzrosloyChickenN = context.PartiyaVzrosloyChicken.Where(h => h.ID == IDn).FirstOrDefault();

            Reproductor reproductor = context.Reproductor.FirstOrDefault();
            int kolvob = reproductor.maxB;
            int kolvon = reproductor.maxN;
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
                return "Готово!";
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
                return "Готово!";
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
                return "Готово!";
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
                return "Готово!";
            }
            else { return "Птицы не выросли"; }
        }
        public string UPKLoad(string a)
        {
            ApplicationContext context = new ApplicationContext();
            int k = 0;
            k = a.IndexOf(";");
            a = a.Substring(0, k);

            int IDa = Convert.ToInt32(a);
            PartiyaVzrosloyChicken partiyaVzrosloyChicken = context.PartiyaVzrosloyChicken.Where(h => h.ID == IDa).FirstOrDefault();
            UPK upk = context.UPK.FirstOrDefault();
            if (upk.FreeOrNotFree)
            {
                upk.KolvoB = partiyaVzrosloyChicken.Kolvo;
                upk.FreeOrNotFree = false;
                upk.Dateform = DateTime.Now;
                partiyaVzrosloyChicken.UPKID = upk.ID;
                partiyaVzrosloyChicken.FreeOrNotFree = false;
                context.SaveChanges();
                return "Готово!";
            }
            else { return "УПК заполнен"; }
        
        }
        public string UPKFormFabricat()
        {
            ApplicationContext context = new ApplicationContext();
            UPK upk = context.UPK.FirstOrDefault();
            if (upk.FreeOrNotFree == false)
            {
               
                    Fabrikat fabrikat = new Fabrikat
                    {
                        Kolvo = upk.KolvoB,
                        UPKID2 = upk.ID,
                        DateUp = DateTime.Now
                    };
                    context.Fabrikat.Add(fabrikat);
                    context.SaveChanges();
                
                upk.KolvoB = 0;
                upk.FreeOrNotFree = true;
                context.SaveChanges();
                return "Готово!";
            }
            else { return "Птиц нет"; }
        }
        public string KPELoad(string a, string b)
        {
            ApplicationContext context = new ApplicationContext();
            int k = 0;
            k = a.IndexOf(";");
            a = a.Substring(0, k);
            k = b.IndexOf(";");
            b = b.Substring(0, k);
            int IDa = Convert.ToInt32(a);
            int IDb = Convert.ToInt32(b);
            PartiyaVzrosloyChicken partiyaVzrosloyChicken = context.PartiyaVzrosloyChicken.Where(h => h.ID == IDa).FirstOrDefault();
            ComplexProizvodstvaEggs KPE = context.ComplexProizvodstvaEggs.Where(h => h.ID == IDb).FirstOrDefault();
            if (KPE.FreeOrNotFree)
            {
                KPE.KolvoN = partiyaVzrosloyChicken.Kolvo;
                KPE.FreeOrNotFree = false;
                KPE.DateForm = DateTime.Now;
                KPE.Pfeed = true;
                KPE.Pwater = true;
                partiyaVzrosloyChicken.CoPrID = KPE.ID;
                partiyaVzrosloyChicken.FreeOrNotFree = false;
                context.SaveChanges();
                return "Готово!";
            }
            else { return "КПЯ заполнен"; }

        }
        public string KPEFormEggs(int b, string a)
        {
            ApplicationContext context = new ApplicationContext();
            int k = a.IndexOf(";");
            a = a.Substring(0, k);
            int IDb = Convert.ToInt32(a);
            ComplexProizvodstvaEggs KPE = context.ComplexProizvodstvaEggs.Where(h => h.ID == IDb).FirstOrDefault();
            if (KPE.FreeOrNotFree == true)
                return "Птиц нет";
            
            if(KPE.Cikl >= KPE.CiklMax && KPE.FreeOrNotFree == false)
            {
                KPE.KolvoN = 0;
                KPE.FreeOrNotFree = true;
                KPE.Pfeed = false;
                KPE.Pwater = false;
                KPE.Cikl = 0;
                context.SaveChanges();
                return "Курицы слишком стары и были отправлены на убой";
            }
            else
            {
                PartiyaEggs partiyaEggs = new PartiyaEggs
                {
                    CoPrID2 = KPE.ID,
                    DateForm = DateTime.Now,
                    Kolvo = b,
                    FreeOrNotFree = true
                };
                KPE.Cikl++;
                context.PartiyaEggs.Add(partiyaEggs);
                context.SaveChanges();
                return "Готово!";
            }
        }
        
        public string CSEFormEgg(int b, string a, int[] category)
        {
            int c = 0;
            ApplicationContext context = new ApplicationContext();
            int k = a.IndexOf(";");
            a = a.Substring(0, k);
            int IDb = Convert.ToInt32(a);
            PartiyaEggs partiyaEggs = context.PartiyaEggs.Where(h => h.ID == IDb).FirstOrDefault();
            CehSortEggs cse = context.CehSortEggs.FirstOrDefault();

            for (int i = 0; i < category.Length; i++) { c += category[i]; }
            if (c > partiyaEggs.Kolvo)
                return "Неточность введенных данных";
            if (partiyaEggs.FreeOrNotFree == true)
            {
                partiyaEggs.CehSortID = cse.ID;
                partiyaEggs.FreeOrNotFree = false;
                context.SaveChanges();
                for (int i = 0; i < category.Length; i++ )
                {
                    PartiyaTovarnEggs partiyaTovarnEggs = new PartiyaTovarnEggs
                    {
                        CehSortID2 = cse.ID,
                        DateUp = partiyaEggs.DateForm,
                        Kolvo = category[i],
                        Categori = i,
                    };
                    context.PartiyaTovarnEggs.Add(partiyaTovarnEggs);
                    context.SaveChanges();
                    
                }
                OtbrakovkaEggs otbrakovkaEggs = new OtbrakovkaEggs
                {
                    CehSortID3 = cse.ID,
                    dateTime = partiyaEggs.DateForm,
                    kolvo = b,
                };
                context.OtbrakovkaEggs.Add(otbrakovkaEggs);
                context.SaveChanges();
                return "Готово";
            }
            else
            {
                return "Проверьте правильность выбранных данных";
            }
        }


        public string CPMFormMelanj(int b,  int j, string a)
        {
            ApplicationContext context = new ApplicationContext();
            int k = a.IndexOf(";");
            a = a.Substring(0, k);
            int IDb = Convert.ToInt32(a);
            OtbrakovkaEggs otbrakovkaEggs = context.OtbrakovkaEggs.Where(h => h.ID == IDb).FirstOrDefault();
            CehProizvMelanja cpm = context.CehProizvMelanja.FirstOrDefault();
            if (otbrakovkaEggs.FreeOrNotFree == true)
            {
                otbrakovkaEggs.CehPrMID2 = cpm.ID;
                otbrakovkaEggs.FreeOrNotFree = false;
                context.SaveChanges();
                for (int i = 0; i < b; i++)
                {
                    Melanj melanj = new Melanj
                    {
                        CehPrMID = cpm.ID,
                        DateRosliva = otbrakovkaEggs.dateTime,
                        TypeMelanga = "Белок",
                    };
                    context.Melanj.Add(melanj);
                    context.SaveChanges();

                }
                for (int i = 0; i < j; i++)
                {
                    Melanj melanj = new Melanj
                    {
                        CehPrMID = cpm.ID,
                        DateRosliva = otbrakovkaEggs.dateTime,
                        TypeMelanga = "Желток",
                    };
                    context.Melanj.Add(melanj);
                    context.SaveChanges();
                }
                return "Готово";
            }
            else
            {
                return "Проверьте правильность выбранных данных";
            }
        }

    }
}
