using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
namespace LogicaNegocio
{
    public class LogicaPlato
    {

        private static DCRestauranteDataContext dc { get; set; }

        //list plato
        public static List<plato> getPlato()
        {
            try
            {
                dc = new DCRestauranteDataContext();
                var plato = dc.platos.Where(data
                      => data.estado_plato == 'A');
                return plato.ToList();
            }
            catch (Exception ex)
            {

                throw new ArgumentException("ERROR" + ex.Message);
            }
        }

        //insert plato
        public static bool savePlato(plato _infoplato)
        {
            try
            {
                dc = new DCRestauranteDataContext();
                bool res = false;
                _infoplato.estado_plato = 'A';
                _infoplato.fecha_plato = DateTime.Now;
                dc.platos.InsertOnSubmit(_infoplato);
                dc.SubmitChanges();
                res = true;
                return res;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("ERROR" + ex.Message);
            }
        }

        //delete plato
        public static bool deletePlato(plato _infoplato)
        {
            try
            {
                bool res = false;
                _infoplato.estado_plato = 'I';
                dc.SubmitChanges();
                res = true;
                return res;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("ERROR" + ex.Message);
            }
        }

    }
}
