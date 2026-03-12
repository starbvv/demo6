using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Logging;
using WinFormsApp11.Models;

namespace WinFormsApp11.Service.ForDB
{
    internal class CheckLogin
    {
        public static bool CheckValidLogin(string Name, string Password)
        {
            using var db = new Connect();
            var check = db.Login.FirstOrDefault(a => a.Name == Name && a.Password == Password);
            if (check != null)
            {
                return true;
                MessageBox.Show("Добро пожаловать!");
            }
            return false;
        }
    }
}