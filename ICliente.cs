using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Tienda
{
    internal interface ICliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Télefono { get; set; }
    }
}
