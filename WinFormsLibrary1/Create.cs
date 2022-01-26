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
            Reproductor reproductor = new Reproductor
            {
                KolvoB = 0,
                KolvoN = 0,
            };
            for (int i = 0; i < 7; i++)
            {
                Incubator incubator = new Incubator
                {
                    DatePost = DateTime.Now,
                    KolvoEggs = 0,
                };
                context.Incubator.Add(incubator);
                context.SaveChanges();
            }
            context.Reproductor.Add(reproductor);
            context.SaveChanges();
        }
    }
}
