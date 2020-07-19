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
    public partial class wfmInicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadmenu();
            }
        }

        private void loadmenu()
        {
            List<plato> _listaPlato = new List<plato>();
            _listaPlato = LogicaPlato.getPlato();
            DataList1.DataSource = _listaPlato.Select(data => new
            {
                ID = data.id_plato,
                Nombre = data.nombre_plato,
                Descripcion = data.descripcion_plato,
                Precio = data.precio_plato.ToString("0.00"),
                URL = data.imagen_plato
            }).ToList();
            DataList1.DataBind();
        }
    }
}