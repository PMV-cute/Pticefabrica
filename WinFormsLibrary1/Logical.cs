﻿using Npgsql;
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
        public string ReproductorLog(int a, int b, int c, DateTime date) 
        {
            ApplicationContext context = new ApplicationContext();
            
            Reproductor reproductor = context.Reproductor.FirstOrDefault();
            reproductor.KolvoB = a;
            reproductor.KolvoN = b;
            int count = c%1000;

            var repr = context.Reproductor.ToList();
            if(c > 0) 
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
                PartiyaEggsRodClass partiyaEggsRodClass1 = new PartiyaEggsRodClass
                {
                    Kolvo = count,
                    RepID = repr[repr.Count - 1].RepID,
                    DatePostEggs = date
                };
                context.PartiyaEggsRodClass.Add(partiyaEggsRodClass1);
                //PartiyaEggsRodClass partiyaEggsRodClass = context.PartiyaEggsRodClass.Where(h => h.ID == 1).FirstOrDefault(); //Удаление сущности из таблицы
                //context.PartiyaEggsRodClass.Remove(partiyaEggsRodClass);
                context.SaveChanges();
            }
            //context.Reproductor.Update();
            var partrod = context.PartiyaEggsRodClass.ToList();
            var repr1 = context.Reproductor.ToList();
            return $"{repr1[repr1.Count - 1].RepID};" +
                $"{repr1[repr1.Count - 1].KolvoB};" +
                $"{repr1[repr1.Count - 1].KolvoN};" +
                $"{ partrod[partrod.Count - 1].DatePostEggs};";
        }
        public string IncubatorLog(string a, string b)
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
                partiyaEggsRodClass.FreeOrNotFree = false;
                incubator.DatePost = DateTime.Now;
                incubator.FreeOrNotFree = false;
                partiyaEggsRodClass.IncID2 = incubator.ID;
                context.SaveChanges();
                return "";
            }
            else { return "Инкубатор заполнен"; }
        }
            
    }
}