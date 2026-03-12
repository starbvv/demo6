using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp11.Models
{
    public class CheckArenda
    {
        public int Id { get; set; }
        public Place Place { get; set; } = new();
        public DateTime EndData { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}
