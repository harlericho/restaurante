using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
namespace LogicaNegocio
{
    public class LogicaCliente
    {
        private static DCRestauranteDataContext dc { get; set; }

        //list users
        public static List<cliente> getClients()
        {
            try
            {
                dc = new DCRestauranteDataContext();
                var client = dc.clientes.Where(data
                      => data.estado_cliente == 'A');
                return client.ToList();
            }
            catch (Exception ex)
            {

                throw new ArgumentException("ERROR" + ex.Message);
            }
        }

        //insert users
        public static bool saveClients(cliente _infoClient)
        {
            try
            {
                dc = new DCRestauranteDataContext();
                bool res = false;
                _infoClient.estado_cliente = 'A';
                _infoClient.fecha_cliente = DateTime.Now;
                dc.clientes.InsertOnSubmit(_infoClient);
                dc.SubmitChanges();
                res = true;
                return res;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("ERROR" + ex.Message);
            }
        }

        //delete users
        public static bool deleteClients(cliente _infoClient)
        {
            try
            {
                bool res = false;
                _infoClient.estado_cliente = 'I';
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
