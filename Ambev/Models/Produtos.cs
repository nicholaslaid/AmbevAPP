using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.Models
{
    public class Produtos
    {
        public int id { get; set; }
        public string nome { get; set; }

        public float volume { get; set; }

        public string tipo { get; set; }

        public string marca { get; set; }

        public DateTime data { get; set; }
        public string frasco { get; set; }
    }
}
