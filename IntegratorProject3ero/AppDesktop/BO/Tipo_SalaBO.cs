using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop.BO
{
    class Tipo_SalaBO
    {
        private int codigo_tipo;
        private string nombre_tipo;
        private double precio_tipo;

        public string Nombre_tipo { get => nombre_tipo; set => nombre_tipo = value; }
        public double Precio_tipo { get => precio_tipo; set => precio_tipo = value; }
        public int Codigo_tipo { get => codigo_tipo; set => codigo_tipo = value; }
    }
}
