﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsLibrary1
{
     public class Context
    {
        public static ApplicationContext Db { get; private set; }
        internal static void AddDb(ApplicationContext application)
        {
            Db = application;
        }
        public Context(ApplicationContext applicationContext)
        {
            Db = applicationContext;
        }
    }
}
