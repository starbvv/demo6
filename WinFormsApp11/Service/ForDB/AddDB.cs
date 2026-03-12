using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp11.Models;

namespace WinFormsApp11.Service.ForDB
{
    internal class AddDB
    {
        public static void AddPlace(int number, int etazh, string category, string desc)
        {
            try
            {
                using var db = new Connect();
                var addPlace = new Place
                {
                    Number = number,
                    Etazh = etazh,
                    Category = category,
                    Desc = desc
                };

                db.Place.Add(addPlace);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Не удалось добавить место");
            }
        }
        public static void AddPple(string surname, string name, string lactname)
        {
            try
            {
                using var db = new Connect();
                var addPple = new Pple
                {
                    Surname = surname,
                    Name = name,
                    LastName = lactname
                };

                db.Pple.Add(addPple);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Не удалось добавить человека");
            }
        }
        public static void AddArenda(Place place, Pple pple, DateTime startDate, DateTime endDate)
        {
            try
            {
                using var db = new Connect();
                db.Place.Attach(place);
                db.Pple.Attach(pple);
                var addArenda = new ZppleLifePelmeni
                {
                    Places = place,
                    Pple = pple,
                    StartTime = startDate,
                    EndTime = endDate
                };

                db.ZppleLifePelmeni.Add(addArenda);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Не удалось оформить контракт на сво(((((");
            }
        }
        public static void AddEnd(Place place, DateTime EndData, string Status)
        {
            try
            {
                using var db = new Connect();
                db.Place.Attach(place);
                var addEnd = new CheckArenda
                {
                    Place = place,
                    EndData = EndData,
                    Status = Status
                };

                db.CheckArenda.Add(addEnd);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Не удалось добавить выезд");
            }
        }
    }
}
