using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaNegocio;

namespace App_Adopciones_Master.InicioSesion
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Intentos"] == null)
            {
                Session["Intentos"] = 0;
            }
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            int intentos = Convert.ToInt32(Session["Intentos"].ToString());
            
        }
    }
}