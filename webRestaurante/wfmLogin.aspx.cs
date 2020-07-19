using AccesoDatos;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webRestaurante
{
    public partial class wfmLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }



        //guardar
        private void login()
        {
            usuario _infoUsers = new usuario();
            _infoUsers = LogicaUsuario.getUsersLogin(txtEmail.Text, txtPass.Text);
            if (_infoUsers != null)
            {
                Session["users"] = _infoUsers;
                if (_infoUsers.id_rol == 1)
                {
                    Response.Redirect("wfmInicio.aspx");
                }
            }
            else
            {
                Response.Write("<script>alert('Usuario o contraseña son incorrectas!!');</script>");
                txtPass.Focus();
            }
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            login();
        }
    }
}