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
        public bool GetReport()
        {
            ApplicationContext context = new ApplicationContext();
            List<Melanj> b = context.Melanj.ToList();
            return new GenerationExel().Generate(b,"d","d","d");

            //return
        }
        
    }
}
