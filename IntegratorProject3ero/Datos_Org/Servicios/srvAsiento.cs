using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos_Org.Modelo;


namespace Datos_Org.Servicios
{
    public class srvAsiento
    {

        public List<Asiento> GetAsiento()//método para obtener todos los datos del asiento
        {
            using (var db = new Cinema_Model())
            {
                return db.Asiento.ToList();
            }
        }

        /*Método para obtener los id de sala*/
        public List<Sala> getSala()//método para obtener todos los datos del asiento
        {
            using (var db = new Cinema_Model())
            {
                return db.Sala.ToList();
            }
        }
        /*Agregar Asientos*/
        public void AgregarAsiento(Asiento item)
        {
            try
            {
                using (var db = new Cinema_Model())
                {
                    db.Asiento.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Verifica los datos a Insertar");//es un error que yo creo
            }
        }
    }
}
