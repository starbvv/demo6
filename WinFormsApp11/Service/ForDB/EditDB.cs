using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WinFormsApp11.Models;

namespace WinFormsApp11.Service.ForDB
{
    internal class EditDB
    {
        public static void EditPlace(int id, int number, int etazh, string category, string desc)
        {
            try
            {
                using var db = new Connect();
                var editPlace = new Place
                {
                    Id = id,
                    Number = number,
                    Etazh = etazh,
                    Category = category,
                    Desc = desc
                };
                db.Update(editPlace);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Не удалось обновить место");
            }
        }
        public static void EditPple(int id, string surname, string name, string lastname)
        {
            try
            {
                using var db = new Connect();
                var editPple = new Pple
                {
                    Id = id,
                    Surname = surname,
                    Name = name,
                    LastName = lastname
                };
                db.Update(editPple);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Не удалось обновить место");
            }
        }
        public static void EditArenda(int id, int idPlace, int idPple, DateTime startDate, DateTime endDate)
        {
            try
            {
                using var db = new Connect();
                var editArenda = db.ZppleLifePelmeni.Include(a => a.Places.Id).Include(a => a.Pple.Id).FirstOrDefault(a => a.Id == id);

                editArenda.StartTime = startDate;
                editArenda.EndTime = endDate;
                db.Update(editArenda);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Не удалось обновить аренду");
            }
        }
    }
}
