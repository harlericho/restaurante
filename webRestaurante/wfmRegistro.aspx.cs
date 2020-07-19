using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicaNegocio;
namespace webRestaurante
{
    public partial class wfmRegistro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        //nuevo

        private void newUsers()
        {
            txtNombres.Text = "";
            txtEmail.Text = "";
            txtPass.Text = "";
            txtPassRepetir.Text = "";
        }

        //guardar
        private void saveUsers()
        {
            usuario _infoUsers = new usuario();
            _infoUsers.nombre_usuario = txtNombres.Text.ToUpper();
            _infoUsers.email_usuario = txtEmail.Text.ToLower();
            _infoUsers.pass_usuario = txtPassRepetir.Text;
            _infoUsers.id_rol = 1;
            bool res = LogicaUsuario.saveUsers(_infoUsers);
            if (res)
            {
                Response.Write("<script>alert('Usuario guardado correctamente.!!');</script>");
                newUsers();
            }
        }

        protected void btnResgistar_Click(object sender, EventArgs e)
        {
            usuario _infoUsers2 = new usuario();
            if (txtPass.Text.Equals(txtPassRepetir.Text))
            {
                _infoUsers2 = LogicaUsuario.getUsersReferencie1(txtEmail.Text);
                if (_infoUsers2 != null)
                {
                    Response.Write("<script>alert('Email ya existe....Revisar!!');</script>");
                    txtEmail.Focus();
                }
                else 
                {
                    saveUsers();
                }
            }
            else
            {
                Response.Write("<script>alert('Contraseñas no coinciden....Revisar!!');</script>");
                txtPass.Focus();
            }
        }
    }
}