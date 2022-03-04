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
    public class Reporter
    {
        /**/
        public bool GetReport(int year, int kvartal)
        {
            DateTime startdate = DateTime.Now;
            DateTime enddate = DateTime.Now;
            if (kvartal == 1)
            {
                startdate = new DateTime(year, 1, 1);
                enddate = new DateTime(year, 4, 1);
            }
            if (kvartal == 2)
            {
                startdate = new DateTime(year, 4, 1);
                enddate = new DateTime(year, 7, 1);
            }
            if (kvartal == 3)
            {
                startdate = new DateTime(year, 7, 1);
                enddate = new DateTime(year, 10, 1);
            }
            if (kvartal == 4)
            {
                startdate = new DateTime(year, 10, 1);
                enddate = new DateTime(year + 1, 1, 1);
            }
            //string[][] rep = new string[][];
            ApplicationContext context = new ApplicationContext();
            List<Melanj> b = context.Melanj.Where(h => h.DateRosliva >= startdate && h.DateRosliva < enddate).ToList();
            //string[][] rep = new string[b.Count][];
            List<List<String>> report = new List<List<String>>();
            foreach (var item in b)
            {
                List<String> vs = new List<String>();
                vs.Add(item.Ntari.ToString());
                vs.Add(item.TypeMelanga.ToString());
                vs.Add(item.DateRosliva.ToString());
                report.Add(vs);
            }
            List<string> namesColumn = new List<string> { "Номер", "Тип", "Дата разлива"};
            new GenerationExel().Generate(report, $"Melanj_Q{kvartal}", $"{year}", "Melanj", namesColumn);

            namesColumn.Clear();
            report.Clear();
            List<Fabrikat> fab = context.Fabrikat.Where(h => h.DateUp >= startdate && h.DateUp < enddate).ToList();
            foreach (var item in fab)
            {
                List<String> vs = new List<String>();
                vs.Add(item.ID.ToString());
                vs.Add(item.DateUp.ToString());
                report.Add(vs);
            }
            namesColumn.Add("Номер");
            namesColumn.Add("Дата");
            new GenerationExel().Generate(report, $"Fabrikat_Q{kvartal}", $"{year}", "Fabrikat", namesColumn);

            namesColumn.Clear();
            report.Clear();
            List<PartiyaTovarnEggs> tov = context.PartiyaTovarnEggs.Where(h => h.DateUp >= startdate && h.DateUp < enddate).ToList();

            foreach (var item in tov)
            {
                List<String> vs = new List<String>();
                vs.Add(item.ID.ToString());
                vs.Add(item.Kolvo.ToString());
                vs.Add(item.DateUp.ToString());
                vs.Add(item.Categori.ToString());
                
                report.Add(vs);
            }
            namesColumn.Add("Номер");
            namesColumn.Add("Количество");
            namesColumn.Add("Дата");
            namesColumn.Add("Категория");
            new GenerationExel().Generate(report, $"TovarnEggs_Q{kvartal}", $"{year}", $"Товарные яйца", namesColumn);

            return true;
        }
        
    }
}
