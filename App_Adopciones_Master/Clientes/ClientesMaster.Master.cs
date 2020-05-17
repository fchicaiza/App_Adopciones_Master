using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaNegocio;


namespace App_Adopciones_Master.Clientes
{
    public partial class ClientesMaster : System.Web.UI.MasterPage
    {
        public string avatar;
        public string nombre;
        public string rol;
        public string usuario;
      

    
        protected void Page_Load(object sender, EventArgs e)
        {

           
            if(Request.QueryString["id"]!= null)
            {

                ControladorClientes cli = new ControladorClientes();
                string id;
                id = Request.QueryString["id"];
                string nom = Convert.ToString(cli.IdNombre(Convert.ToInt32(id)));
                string ape = Convert.ToString(cli.IdApellido(Convert.ToInt32(id)));
                string ava = Convert.ToString(cli.IdAvatar(Convert.ToInt32(id)));

                nombre = nom + ape;
                avatar = ava;
            }
            if (Session["Cliente"] != null)
            {
                Sp_LoginResult usu = (Sp_LoginResult)Session["Cliente"];
                usuario = usu.user_usu;
                rol = usu.des_rol;

           
            }

            else
            {
                Response.Redirect("~/InicioSesion/Login.aspx");
            }
            
        }
    }
}