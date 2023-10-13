using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.Models
{
    public class Vendas
    {
        public int id { get; set; }
        public DateTime dataVenda { get; set; }

        public string Cliente { get; set; }

        public string Vendedor { get; set; }

        public int qtd_produtos { get; set; }

        public double valorTotal { get; set; }
    }
}
