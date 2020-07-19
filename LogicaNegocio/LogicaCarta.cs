using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
namespace LogicaNegocio
{
    public class LogicaCarta
    {
        private static DCRestauranteDataContext dc { get; set; }

        //list carta
        public static List<carta> getCarta()
        {
            try
            {
                dc = new DCRestauranteDataContext();
                var carta = dc.cartas.Where(data
                      => data.estado_carta == 'A');
                return carta.ToList();
            }
            catch (Exception ex)
            {

                throw new ArgumentException("ERROR" + ex.Message);
            }
        }

        //insert carta
        public static bool saveCarta(carta _infoCarta)
        {
            try
            {
                dc = new DCRestauranteDataContext();
                bool res = false;
                _infoCarta.estado_carta = 'A';
                _infoCarta.fecha_carta = DateTime.Now;
                dc.cartas.InsertOnSubmit(_infoCarta);
                dc.SubmitChanges();
                res = true;
                return res;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("ERROR" + ex.Message);
            }
        }

        //delete carta
        public static bool deleteCarta(carta _infoCarta)
        {
            try
            {
                bool res = false;
                _infoCarta.estado_carta = 'I';
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
