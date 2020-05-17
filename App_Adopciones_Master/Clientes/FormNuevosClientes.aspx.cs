using CapaDatos;
using CapaNegocio;
using System;
using Validaciones;

namespace App_Adopciones_Master.Clientes
{
    public partial class FormNuevosClientes : System.Web.UI.Page
    {
        public String imagen;
        string id;
        DataClasses1DataContext conn = new DataClasses1DataContext();
        ControladorPersona per = new ControladorPersona();
        ValCedula val = new ValCedula();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alerta", "<script>completar();</script>");
            }
        }
        // Agregar Sessiones
        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["id"]!=null)
            {
                id = Request.QueryString["id"];

                if (img_up.HasFile)
                {
                    string img = img_up.FileName;
                    string ruta = "../assets/avatar/" + img;
                    imagen = "../assets/avatar/" + img;
                    img_up.SaveAs(Server.MapPath(ruta));

                }
                if (per.CompararCedula(txt_dni.Text)!=null)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alerta", "<script>registrado();</script>");
                }
                else if (val.ValidarCedula(txt_dni.Text)==true)
                {
                    int dni = Convert.ToInt32(txt_dni.Text);
                    conn.Sp_EditarPersona
                        (
                        Convert.ToString(dni),
                        txt_nombres.Text,
                        txt_apellidos.Text,
                        txt_telefono.Text,
                        txt_cllp.Text,
                        txt_clls.Text,
                        txt_num.Text,
                        Convert.ToChar("A"),
                        Convert.ToInt32(id),
                        imagen
                        );
                    Response.Redirect("~/Clientes/TableroClientes.aspx");
                }
            }
        }
    }
}