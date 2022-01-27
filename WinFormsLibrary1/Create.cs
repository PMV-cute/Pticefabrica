﻿using System;
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
            Reproductor reproductor = new Reproductor
            {
                KolvoB = 0,
                KolvoN = 0,
            };
            for (int i = 0; i < 21; i++)
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
            for (int i = 0; i < 21; i++)
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
            context.Reproductor.Add(reproductor);
            context.SaveChanges();
        }
    }
}
