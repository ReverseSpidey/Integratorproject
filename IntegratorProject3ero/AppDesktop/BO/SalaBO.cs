using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop.BO
{
    class SalaBO
    {
        private int cod_sala;
        private int num_sala;
        private int cod_tipo;

        public int Cod_sala { get => cod_sala; set => cod_sala = value; }
        public int Num_sala { get => num_sala; set => num_sala = value; }
        public int Cod_tipo { get => cod_tipo; set => cod_tipo = value; }
    }
}
