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
                Response.Write("<script>window.alert('Correo electrónico ya existe')</script>");
            }else

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
                temp
                );


                Sp_BuscarClaveTemResult corr = reg.EnviarCorreo(txt_email.Text);

                try
                {
                    if(corr != null)
                    {
                        reg.EnviarClTemp(corr.ema_usu, corr.cltm_usu);
                         Response.Write("<script>window.alert('Correo enviado correctamente, revise su bandeja de entrada," +
                             "si no lo encuentra, revise en correo no deseado')</script>");
                    }
                    else
                    {
                        Response.Write("<script>window.alert('Correo no encontrado')</script>");
                    }
                }
                catch (Exception ex)
                {
                    Console.Write(ex);

                    Response.Write("<script>window.alert('Correo no enviado')</script>");

                }
               string mail = txt_email.Text;

                int id = Convert.ToInt32(reg.IdMail(mail));

                Response.Redirect("~/InicioSesion/FormAsignarClave.aspx?id=" + id);

            }

        }

        }

}