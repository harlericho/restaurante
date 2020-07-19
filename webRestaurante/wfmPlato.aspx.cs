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
    public partial class wfmUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                mostrarTiposCartas();
            }
        }


        //cargar los tipos o cartas
        private void mostrarTiposCartas()
        {
                List<carta> _infoCarta = new List<carta>();
                _infoCarta = LogicaCarta.getCarta();
                if (_infoCarta.Count > 0 && _infoCarta != null)
                {
                    _infoCarta.Insert(0, new carta { id_carta = 0, descripcion_carta = "--Seleccione--" });
                    ddlTiposCartas.DataSource = _infoCarta;
                    ddlTiposCartas.DataTextField = "descripcion_carta";
                    ddlTiposCartas.DataValueField = "id_carta";
                    ddlTiposCartas.DataBind();
                }

        }


        //nuevo
        private void newPlato()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            ddlTiposCartas.SelectedIndex = 0;
            ddlTiposCartas.Focus();
        }


        //guardar
        private void savePlato()
        {
            plato _infoPalto = new plato();
            _infoPalto.id_carta = Convert.ToInt16(ddlTiposCartas.SelectedValue);
            _infoPalto.nombre_plato = txtNombre.Text.ToUpper();
            _infoPalto.descripcion_plato = txtDescripcion.Text.ToUpper();
            _infoPalto.precio_plato = Convert.ToDecimal(txtPrecio.Text);

            if (FileUpload1.HasFile)
            {
                if (!string.IsNullOrEmpty(txtNombre.Text))
                {
                    try
                    {
                        if (FileUpload1.PostedFile.ContentType == "image/png" || FileUpload1.PostedFile.ContentType == "image/jpeg" || FileUpload1.PostedFile.ContentType == "image/jpg")
                        {
                            string nombreArchivo = txtNombre.Text + ".jpg";
                            FileUpload1.SaveAs(Server.MapPath("~/Images/Platos/") + nombreArchivo);
                        }
                    }
                    catch (Exception ex)
                    {

                        throw new ArgumentException("ERROR" + ex.Message);
                    }
                }
            }
            _infoPalto.imagen_plato = "~/Images/Platos/" + txtNombre.Text + ".jpg";
            bool res = LogicaPlato.savePlato(_infoPalto);
            if (res)
            {
                Response.Write("<script>alert('Plato guardado correctamente.!!');</script>");
                newPlato();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            savePlato();
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            newPlato();
        }
    }
}