﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Tienda
{
    internal class Venta
    {
        public int Id { get; set; }
        public string NombreCliente { get; set; }
        public string NombreProducto { get; set; }
        public double Total { get; set; }

        public Venta(int id, string nombreCliente, string nombreProducto, double total)
        {
            Id = id;
            NombreCliente = nombreCliente;
            NombreProducto = nombreProducto;
            Total = total;
        }
    }
}
