using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principalito.cs
{
    public class Venta
    {
        public int VentaId { get; set; }
        public int ProductoId { get; set; }
        public int ClienteId { get; set; }
        public int VendedorId { get; set; }
        public int CantidadVenta { get; set; }
        public int ValorTotal { get; set; }
        public DateTime FechaVenta { get; set; }
    }
}
