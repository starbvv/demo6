using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp11.Models
{
    internal class Login
    {
        [Browsable(false)]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        [Browsable(false)]
        public bool Admin { get; set; } = false;
    }
}
