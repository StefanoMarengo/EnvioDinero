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
        public bool ControlarSaldo(decimal monto)
        {
            return Saldo < monto ? false : true;
        }
        public void Transaccion(decimal monto, string descripcion) //Capaz se puede hacer en set o get
        {
            Saldo += monto;
            Movimientos.Add(new Movimiento(this.Movimientos.Count, DateTime.Now, descripcion, monto));
        }
        public List<Movimiento> GetListaOrdenada()
        {
            return Movimientos.OrderBy(x=>x.Fecha).ToList();
        }
    }
}
