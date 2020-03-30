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
    public partial class FormAsignarClave : System.Web.UI.Page
    {
        CotroladorRegistro reg = new CotroladorRegistro();
        DataClasses1DataContext conn = new DataClasses1DataContext();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_clave_Click(object sender, EventArgs e)
        {
            string temp = txt_temp.Text;
            int id;
            string mail;

            id = Convert.ToInt32(conn.Sp_BuscarIdUsu(temp));
            mail = Convert.ToString(reg.BuscarEmail(temp));

            if (reg.BuscarClaveTemporal(txt_temp.Text) != null )
            {

                ClientScript.RegisterStartupScript(this.GetType(), "alerta", "<script>registrado();</script>");

            }
            else if(txt_neva.Text == txt_conf.Text) {
               
                conn.Sp_InsertarUsuario(
                    txt_usuario.Text,
                    txt_neva.Text,
                    Convert.ToChar("A"),
                    mail,
                    txt_temp.Text = (" ")
                    );
                
            }
        }


    }
}