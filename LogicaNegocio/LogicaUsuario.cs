using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace LogicaNegocio
{
    public class LogicaUsuario
    {
        private static DCRestauranteDataContext dc { get; set; }

        //list users
        public static List<usuario> getUsers()
        {
            try
            {
                dc = new DCRestauranteDataContext();
                var users = dc.usuarios.Where(data
                      => data.estado_usuario == 'A');
                return users.ToList();
            }
            catch (Exception ex)
            {

                throw new ArgumentException("ERROR" + ex.Message);
            }
        }

        //validacions registrer
        public static usuario getUsersReferencie1(string dataUsers)
        {
            try
            {
                dc = new DCRestauranteDataContext();
                var usuario = dc.usuarios.FirstOrDefault(data => data.estado_usuario == 'A'
                && data.email_usuario.Equals(dataUsers));
                return usuario;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("ERROR" + ex.Message);
            }
        }


        //validacions login
        public static usuario getUsersLogin(string user, string pass)
        {
            try
            {
                dc = new DCRestauranteDataContext();
                var usuario = dc.usuarios.FirstOrDefault(data => data.estado_usuario == 'A'
                && data.email_usuario.Equals(user) && data.pass_usuario.Equals(pass));
                return usuario;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("ERROR" + ex.Message);
            }
        }


        //insert users
        public static bool saveUsers(usuario _infoUser)
        {
            try
            {
                dc = new DCRestauranteDataContext();
                bool res = false;
                _infoUser.estado_usuario = 'A';
                _infoUser.fecha_usuario = DateTime.Now;
                dc.usuarios.InsertOnSubmit(_infoUser);
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
        public static bool deleteUsers(usuario _infoUser)
        {
            try
            {
                bool res = false;
                _infoUser.estado_usuario = 'I';
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
