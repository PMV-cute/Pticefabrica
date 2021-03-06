using System;
using System.Collections.Generic;
using System.Text;
using WinFormsLibrary1.Entity;
using WinFormsLibrary1;
using System.Linq;

namespace WinFormsLibrary1
{
    public class Create
    {
        public void CreateAll()
        {
            ApplicationContext context = new ApplicationContext();
            var users = context.Reproductor.ToList();
            foreach (var u in users)
            {
                if (u.RepID == u.RepID)
                {
                    return;
                }
            }
            Pticefabrica pticefabrica = new Pticefabrica
            {
                Addres = "г. Киров Кировская обл. ул. Московская д. 1.",
                Name = "Птицефабрика №1",
                Number = 1,
            };
            context.pticefabrica.Add(pticefabrica);
            context.SaveChanges();
            Reproductor reproductor = new Reproductor
            {
                KolvoB = 200,
                KolvoN = 1000
            };
            context.Reproductor.Add(reproductor);
            context.SaveChanges();
            for (int i = 0; i < 7; i++)
            {
                Incubator incubator = new Incubator
                {
                    DatePost = DateTime.Now,
                    KolvoEggs = 0,
                    DayOfBorn = DateTime.Now.AddYears(100)
                };
                context.Incubator.Add(incubator);
                context.SaveChanges();
            }
            for (int i = 0; i < 7; i++)
            {
                Ptichnic ptichnic = new Ptichnic
                {
                    DatePost = DateTime.Now,
                    Kolvo = 0,
                    DateGrow = DateTime.Now.AddYears(100),
                    TypeChicken = "",
                };
                context.Ptichnic.Add(ptichnic);
                context.SaveChanges();
            }
            UPK uPK = new UPK
            {
                KolvoB = 0,
                FreeOrNotFree = true
            };
            context.UPK.Add(uPK);
            context.SaveChanges();
            for (int i = 0; i < 7; i++)
            {
                ComplexProizvodstvaEggs complexProizvodstvaEggs = new ComplexProizvodstvaEggs
                {
                    KolvoN = 0,
                };
                context.ComplexProizvodstvaEggs.Add(complexProizvodstvaEggs);
                context.SaveChanges();
            }
            CehSortEggs cehSortEggs = new CehSortEggs
            {
                Kolvo = 0,
                FreeOrNotFree = false,
                DateForm = DateTime.Now
            };
            context.CehSortEggs.Add(cehSortEggs);
            context.SaveChanges();


            // -------------------------------------------------------------------


            for (int i = 0; i < 7; i++)
            {
                PartiyaEggsRodClass partiya = new PartiyaEggsRodClass
                {
                    Kolvo = 1000,
                    DatePostEggs = DateTime.Now,
                };
                context.PartiyaEggsRodClass.Add(partiya);
                context.SaveChanges();
            }
            for (int i = 0; i < 3; i++)
            {
                PartiyaMolodnyaka partiya = new PartiyaMolodnyaka
                {
                    TypeChicken = "Бройлер",
                    DataForm = DateTime.Now,
                    Kolvo = 500
                };
                context.PartiyaMolodnyaka.Add(partiya);
                context.SaveChanges();
            }
            for (int i = 0; i < 3; i++)
            {
                PartiyaMolodnyaka partiya = new PartiyaMolodnyaka
                {
                    TypeChicken = "Несушка",
                    DataForm = DateTime.Now,
                    Kolvo = 500
                };
                context.PartiyaMolodnyaka.Add(partiya);
                context.SaveChanges();
            }
            for (int i = 0; i < 3; i++)
            {
                PartiyaVzrosloyChicken partiya = new PartiyaVzrosloyChicken
                {
                    DateForm = DateTime.Now,
                    Kolvo = 500,
                    TypeChiсken = "Бройлер",
                };
                context.PartiyaVzrosloyChicken.Add(partiya);
                context.SaveChanges();
            }
            for (int i = 0; i < 3; i++)
            {
                PartiyaVzrosloyChicken partiya = new PartiyaVzrosloyChicken
                {
                    DateForm = DateTime.Now,
                    Kolvo = 500,
                    TypeChiсken = "Несушка",
                };
                context.PartiyaVzrosloyChicken.Add(partiya);
                context.SaveChanges();
            }
            for (int i = 0; i < 10; i++)
            {
                PartiyaEggs partiyaEggs = new PartiyaEggs
                {
                    DateForm = DateTime.Now,
                    Kolvo = 500,
                };
                context.PartiyaEggs.Add(partiyaEggs);
                context.SaveChanges();
            }
            CehProizvMelanja cehProizvMelanja = new CehProizvMelanja { };
            context.CehProizvMelanja.Add(cehProizvMelanja);
            context.SaveChanges();
            for (int i = 0; i < 10; i++)
            {
                Melanj melanj = new Melanj
                {
                    TypeMelanga = "Белок",
                    DateRosliva = DateTime.Now,
                    kolvo = 100
                };
                context.Melanj.Add(melanj);
                context.SaveChanges();
            }
            
            for(int i = 0; i < 10; i++)
            {
                Fabrikat fabrikat = new Fabrikat
                {
                    DateUp = DateTime.Now,
                    UPKID2 = 1,
                    kolvo = 100
                };
                context.Fabrikat.Add(fabrikat);
                context.SaveChanges();
            }
            for (int i = 0; i < 10; i++)
            {
                PartiyaTovarnEggs partiyaTovarnEggs = new PartiyaTovarnEggs
                {
                    Kolvo = 100,
                    DateUp = DateTime.Now,
                    Categori = 1,
                };
                context.PartiyaTovarnEggs.Add(partiyaTovarnEggs);
                context.SaveChanges();
            }

            

            string a = new Crypt().getCrypt("1234");
            string b = new Crypt().getCrypt("4321");
            string c = new Crypt().getCrypt("1111");

            LogPas logPas1 = new LogPas { login = "Maksim", password = a, role = "Admin" };
            LogPas logPas2 = new LogPas { login = "Ivan", password = a, role = "Admin" };
            LogPas logPas3 = new LogPas { login = "Alexey", password = c, role = "Руководитель" };
            LogPas logPas4 = new LogPas { login = "Репродуктор", password = b, role = "Репродуктор" };
            LogPas logPas5 = new LogPas { login = "Инкубатор", password = b, role = "Инкубатор" };
            LogPas logPas6 = new LogPas { login = "Птичник", password = b, role = "Птичник" };
            LogPas logPas7 = new LogPas { login = "КПЯ", password = b, role = "КомплексПЯ" };
            LogPas logPas8 = new LogPas { login = "КСЯ", password = b, role = "КомплексСЯ" };
            LogPas logPas9 = new LogPas { login = "УПК", password = b, role = "УПК" };
            LogPas logPas10 = new LogPas { login = "ЦПМ", password = b, role = "ЦехПМ" };

            context.LogPas.AddRange(logPas1, logPas2, logPas3, logPas4, logPas5, logPas6, logPas7, logPas8, logPas9, logPas10); 
            context.SaveChanges();
        }
    }
}
