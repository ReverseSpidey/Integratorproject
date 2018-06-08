using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop.BO
{
    class PeliculaBO
    {
        private int id_pelicula;
        private string nombre_peli;
        private string duracion_peli;
        private string sinopsis;
        private byte[] image;
        private int id_genero;
        private int cod_idioma;
        private int id_clasif;

        public int Id_pelicula { get => id_pelicula; set => id_pelicula = value; }
        public string Nombre_peli { get => nombre_peli; set => nombre_peli = value; }

        public string Sinopsis { get => sinopsis; set => sinopsis = value; }
        public int Id_genero { get => id_genero; set => id_genero = value; }
        public int Cod_idioma { get => cod_idioma; set => cod_idioma = value; }
        public int Id_clasif { get => id_clasif; set => id_clasif = value; }
        public string Duracion_peli { get => duracion_peli; set => duracion_peli = value; }
        public byte[] Image { get => image; set => image = value; }
    }
}
