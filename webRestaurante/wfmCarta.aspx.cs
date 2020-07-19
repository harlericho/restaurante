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
    public partial class wfmCarta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }


        //nuevo
        private void newCarta()
        {
            txtNombre.Text = "";
            txtNombre.Focus();
        }


        //guardar

        private void saveCarta()
        {
            carta _infoCarta = new carta();
            _infoCarta.descripcion_carta = txtNombre.Text.ToUpper();
            bool res = LogicaCarta.saveCarta(_infoCarta);
            if (res)
            {
                Response.Write("<script>alert('Tipo o carta nueva guardada!!');</script>");
                newCarta();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            saveCarta();
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            newCarta();
        }
    }
}