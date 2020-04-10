using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaNegocio;
using static CapaNegocio.ControladorEncriptacion;

namespace App_Adopciones_Master.InicioSesion
{
    public partial class FormAsignarClave : System.Web.UI.Page
    {
        CotroladorRegistro reg = new CotroladorRegistro();
       
        DataClasses1DataContext conn = new DataClasses1DataContext();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alerta", "<script>enviado();</script>");
            }
      
            
        }

        protected void btn_clave_Click(object sender, EventArgs e)
        {
            string temp = txt_temp.Text;
            string id;


            if (Request.QueryString["id"]!=null)
            {
                id = Request.QueryString["id"];

                if (reg.BuscarClaveTemporal(txt_temp.Text) != null)
                {
                    if (txt_neva.Text == txt_conf.Text)
                    {
                        



                        conn.Sp_EditarUsuario1(
                              Convert.ToInt32(id),
                              txt_usuario.Text,
                              Encrypt.GetSHA256(txt_neva.Text)
                            );
                        Response.Write("<script>window.alert('Su contraseña se ha guardado exitosamente')</script>");
                       

                        Response.Redirect("~/InicioSesion/Login.aspx?id=" + id);

                    }
                    else
                    {
                        Response.Write("<script>window.alert('Error!! Las contraseñas no coinciden')</script>");
                    }

                }
                else
                {
                    Response.Write("<script>window.alert('Error!! No se ha encontrado la clave temporal')</script>");
                }
            }
 

        }


    }
}