using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using Datos_Org.Modelo;

namespace Datos_Org.Servicios
{
    public class srvSala
    {
        public List<Sala> getListSALAS()
        {
            using (var db = new Cinema_Model())
            {
                return db.Sala.ToList();
            }
        }



        public List<Sala> Salas()
        {
            List<Sala> obj = new List<Sala>();
            using (var db = new Cinema_Model())
            {
               // var sala_tipo = db.Tipo_sala.Join(db.Sala, id => id.Cod_sala, sal => sal.Cod_sala, (id, sal) => new { id, sal }).ToList();
                var sala_tipo = db.Sala.Join(db.Tipo_sala, id => id.Tipo_sala.Cod_sala, sal => sal.Cod_sala, (id, sal) => new { id, sal }).ToList();
                return db.Sala.ToList();
            }
        }
    }
}
