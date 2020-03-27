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
        public string imagen;
        CotroladorRegistro reg = new CotroladorRegistro();
        ValCedula val = new ValCedula();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_registro_Click(object sender, EventArgs e)
        {
            if (img_perfil.HasFile)
            {
                string imag = img_perfil.FileName;
                string ruta = "../assets/img/" + imag;
                imagen = "../assets/img/" + imag;
                img_perfil.SaveAs(Server.MapPath(ruta));
            }
            if (reg.VerificarRegistro(txt_dni.Text) != null)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alerta", "<script>registrado();</script>");

            }
            else if (val.ValidarCedula(txt_dni.Text) == true)
            {
                // falta mantenimientos login y registro
            }

        }
    }
}