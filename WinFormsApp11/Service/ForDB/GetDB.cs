using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WinFormsApp11.Models;

namespace WinFormsApp11.Service.ForDB
{
    internal class GetDB
    {
        public static List<Place> GetPlaces()
        {
            using var db = new Connect();
            var place = db.Place.ToList();
            return place;
        }
        public static List<Pple> GetPples()
        {
            using var db = new Connect();
            var pple = db.Pple.ToList();
            return pple;
        }
        public static List<ZppleLifePelmeni> GetArenda()
        {
            using var db = new Connect();
            return db.ZppleLifePelmeni.Include(a => a.Places).Include(a => a.Pple).ToList();
        }
    }
}
