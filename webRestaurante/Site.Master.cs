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
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["users"] != null)
                {
                    usuario _infoUsers = new usuario();
                }
                else
                {
                    Response.Redirect("wfmlogin.aspx");
                }
                Response.AppendHeader("Cache-Control", "no-store");
                Response.Cache.SetNoStore();


            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.RemoveAll();
            Response.Redirect("wfmlogin.aspx");
        }
    }
}