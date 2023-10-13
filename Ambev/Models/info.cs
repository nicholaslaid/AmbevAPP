using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.Models
{
    public class info
    {
        public int id_venda { get; set; }
        public int id_produto { get; set; }

        public int qtd { get; set; }

        public double valor_unitario { get; set; }

        public double subtotal { get; set; }
    }
}
