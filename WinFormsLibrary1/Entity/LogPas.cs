using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using WinFormsLibrary1;

namespace WinFormsLibrary1.Entity
{
    public class LogPas
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string login { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string role { get; set; }
        public void LoadData() 
        {
            ApplicationContext context = new ApplicationContext(); 
            LogPas logPas1 = new LogPas { login = "Maksim", password = "1234", role = "Admin" };
            LogPas logPas2 = new LogPas { login = "Ivan", password = "1234", role = "Admin" };
            LogPas logPas3 = new LogPas { login = "Alexey", password = "1234", role = "Руководитель" };
            LogPas logPas4 = new LogPas { login = "Dima", password = "1234", role = "Рабочий" };
            LogPas logPas5 = new LogPas { login = "Artem", password = "1234", role = "Рабочий" };
            context.LogPas.AddRange(logPas1, logPas2, logPas3, logPas4, logPas5); // Добавление данных в бд (Оно не обязательно для создания бд) 
            context.SaveChanges();
        }
    }
}
