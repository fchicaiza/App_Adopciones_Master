using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaNegocio;
using Validaciones;


using static CapaNegocio.ControladorEncriptacion;

namespace App_Adopciones_Master.InicioSesion
{

    public partial class Registro : System.Web.UI.Page
    {
        DataClasses1DataContext conn = new DataClasses1DataContext();
        public string imagen;
        CotroladorRegistro reg = new CotroladorRegistro();
        ValCedula val = new ValCedula();



        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void btn_envio_Click(object sender, EventArgs e)
        {

            
            if (reg.BuscarCorreo(txt_email.Text)!= null)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alerta", "<script>siexiste();</script>");
            }
            else

            if (txt_email != null)
            {


                Random rdn = new Random();
                string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890%$#@";
                int longitud = caracteres.Length;
                char letra;
                int longitudContrasenia = 10;
                string contraseniaAleatoria = string.Empty;
                for (int i = 0; i < longitudContrasenia; i++)
                {
                    letra = caracteres[rdn.Next(longitud)];
                    contraseniaAleatoria += letra.ToString();
    
               }

                DataClasses1DataContext conn = new DataClasses1DataContext();
                string temp = contraseniaAleatoria;
                conn.Sp_InsertarUsuario(
                Convert.ToString(" "),
                Convert.ToString(" "),
                Convert.ToChar("A"),                
                txt_email.Text,
                temp,
                Convert.ToInt32("1002")
                );


                Sp_BuscarClaveTemResult corr = reg.EnviarCorreo(txt_email.Text);
                string email = txt_email.Text;

                int ide = Convert.ToInt32(reg.IdMail(email));

                try
                {
                    if(corr != null)
                    {
                        reg.EnviarClTemp(corr.ema_usu, corr.cltm_usu);
                        
                    }

                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "alerta", "<script>noencontrado();</script>");
                    }
                }
                catch (Exception ex)
                {
                    Console.Write(ex);

                    ClientScript.RegisterStartupScript(this.GetType(), "alerta", "<script>noenviado();</script>");

                }
               string mail = txt_email.Text;

                int id = Convert.ToInt32(reg.IdMail(mail));

                Response.Redirect("~/InicioSesion/FormAsignarClave.aspx?id=" + id);

            }

        }

        }

}