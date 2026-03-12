using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp11.Service.ForDB
{
    internal class DeleteDB
    {
        public static void RemovePlace(int placeId)
        {
            try
            {
                using var db = new Connect();
                var place = db.Place.Find(placeId);
                if (place != null)
                {
                    db.Place.Remove(place);
                    db.SaveChanges();
                }
            }
            catch
            {
                MessageBox.Show("Не удалось удалить место");
            }
        }
        public static void RemovePple(int ppleId)
        {
            try
            {
                using var db = new Connect();
                var pple = db.Pple.Find(ppleId);
                if (pple != null)
                {
                    db.Pple.Remove(pple);
                    db.SaveChanges();
                }
            }
            catch
            {
                MessageBox.Show("Не удалось удалить человека");
            }
        }
        public static void RemoveArenda(int arendaId)
        {
            try
            {
                using var db = new Connect();
                var arenda = db.ZppleLifePelmeni.Find(arendaId);
                if (arenda != null)
                {
                    db.ZppleLifePelmeni.Remove(arenda);
                    db.SaveChanges();
                }
            }
            catch
            {
                MessageBox.Show("Не удалось удалить аренду");
            }
        }
    }
}
