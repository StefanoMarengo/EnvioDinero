using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvioDinero
{
    public class Usuario
    {
        public string NombreApellido { get; set; }
        public int DNI { get; set; }
        public decimal Saldo { get; set; }
        public List<Movimiento> Movimientos { get; set; }
    }
}
