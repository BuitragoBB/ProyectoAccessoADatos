using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principalito.cs
{
    public class Compra
    {
        public int CompraId { get; set; }
        public int ProductoId { get; set; }
        public int ProveedorId { get; set; }
        public int CantidadCompra { get; set; }
        public int ValorCompra { get; set; }
        public DateTime FechaCompra { get; set; }
    }
}
