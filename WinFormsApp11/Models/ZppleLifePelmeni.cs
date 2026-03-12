using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp11.Models
{
    public class ZppleLifePelmeni
    {
        [Browsable(false)]
        public int Id { get; set; }

        [DisplayName("Номер")]
        public Place Places { get; set; } = new();

        [DisplayName("Человек")]
        public Pple Pple { get; set; } = new();

        [DisplayName("Дата заезда")]
        public DateTime StartTime { get; set; } = DateTime.Now.Date;

        [DisplayName("Дата выезда")]
        public DateTime EndTime { get; set; } = DateTime.Now.Date.AddDays(1);
        public override string ToString()
        {
            return Places.ToString() + Pple.ToString();
        }
    }
}
