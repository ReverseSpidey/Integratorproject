using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos_Org.Entidades;
using Datos_Org.Modelo;
using Datos_Org.Servicios;

namespace Datos_Org.Servicios
{
    public class srvFuncion
    {
        public List<vFuncion> Horario(string peli)
        {
            List<vFuncion> obj = new List<vFuncion>();
            using (var db = new Cinema_Model())
            {
                obj = (from x in db.Funcion
                       select new vFuncion
                       {
                           nombre_peli = x.Pelicula.nombre_pelicula,
                           Hora_ini = x.Hora_ini,
                           Cod_sala = x.Cod_sala,
                           ID_funcion = x.ID_funcion


                       }).Where(a => a.nombre_peli == peli).ToList();
                return obj;
            }
        }


    }
}
