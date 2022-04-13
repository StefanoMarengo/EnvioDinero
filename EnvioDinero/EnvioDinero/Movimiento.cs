using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvioDinero
{
    public class Movimiento
    {
        public int ID { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }
        public Movimiento(int iD, DateTime fecha, string descripcion, decimal monto)
        {
            ID = iD;
            Fecha = fecha;
            Descripcion = descripcion;
            Monto = monto;
        }
    }
}
