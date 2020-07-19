using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AccesoDatos;
using LogicaNegocio;
namespace webRestaurante
{
    public partial class wfmUsuarios1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }



        //nuevo
        private void newClients()
        {
            txtNombre.Text = "";
            txtDni.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
        }

        //guardar

        private void saveClients()
        {
            cliente _infoClient = new cliente();
            _infoClient.nombres_cliente = txtNombre.Text.ToUpper();
            _infoClient.direccion_cliente = txtDireccion.Text.ToUpper();
            _infoClient.dni_cliente = txtDni.Text;
            _infoClient.ttelefono_cliente = txtTelefono.Text;
            _infoClient.email_cliente = txtEmail.Text.ToLower();
            bool res = LogicaCliente.saveClients(_infoClient);
            if (res)
            {
                Response.Write("<script>alert('Cliente guardado correctamente.!!');</script>");
                newClients();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            saveClients();
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            newClients();
        }
    }
}