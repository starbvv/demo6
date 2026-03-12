using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp11.Models
{
    public class Pple
    {
        [Browsable(false)]
        public int Id { get; set; }
        [DisplayName("Фамилия")]
        public string Surname { get; set; } = string.Empty;
        [DisplayName("Имя")]
        public string Name { get; set; } = string.Empty;
        [DisplayName("Отчество")]
        public string LastName { get; set; } = string.Empty;
        public override string ToString()
        {
            return Surname + Name + LastName;
        }
    }
}
