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
        string id;
        ControladorLogin usuario = new ControladorLogin();
        ControladorPersona per = new ControladorPersona();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alerta", "<script>claveasignada();</script>");
                }
            }

            if (Session["Intentos"] == null)
            {
                Session["Intentos"] = 0;
            }
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                
                id = Request.QueryString["id"];

                int intentos1 = Convert.ToInt32(Session["Intentos"].ToString());
                Sp_LoginResult user1 = usuario.iniciarSesion(txt_usuario.Text, txt_clave.Text);
                if (user1 != null)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alerta", "<script>correcto()</script>");
                    Session["Administrador"] = user1;
                    if (user1.des_rol.Equals("Administrador"))
                    {
                        Response.Redirect("~/Colaboradores/FormNuevosColaboradores.aspx?id=" + id);
                    }
                    else if (user1.des_rol.Equals("Cliente") && user1.est_usu.Equals(Convert.ToChar("A")))
                    {
                        Response.Redirect("~/Clientes/FormNuevosClientes.aspx?id=" + id);
                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "alerta", "<script>inactivo()</script>");
                        txt_usuario.Text = " ";
                        txt_clave.Text = " ";
                    }
                }
                else
                {
                    if (intentos1 >= 0 && usuario.NoExiste(txt_usuario.Text) == null)
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "alerta", "<script>noexiste()</script>");
                        txt_usuario.Text = " ";
                        txt_clave.Text = " ";
                    }
                    else if (intentos1 >= 2)
                    {
                        Session["Intentos"] = 0;
                        ClientScript.RegisterStartupScript(this.GetType(), "alerta", "<script>timer()</script>");
                        txt_clave.Text = " ";
                    }
                    else
                    {
                        intentos1 = intentos1 + 1;
                        Session["intentos"] = intentos1;
                        ClientScript.RegisterStartupScript(this.GetType(), "alerta", "<script>Swal.fire({" +
                           "icon: 'warning'," +
                           " html: '<div><h2> Alerta!</h2></div><div><h4>Contraseña incorrecta, usted ha agotado " + intentos1 + " intentos</h4></div>'," +
                           "width: '40%'," +
                           "confirmButtonColor: '#EC971F'," +
                           "confirmButtonText: '<h5>Intentar otra vez</h5>'" +
                           "})</script>");
                        txt_clave.Text = " ";
                    }
                }
            }
            else {

            }
            int intentos = Convert.ToInt32(Session["Intentos"].ToString());
            Sp_LoginResult user = usuario.iniciarSesion(txt_usuario.Text, txt_clave.Text);
            if (user != null)
            {

                string usuario = txt_usuario.Text;
                int id = Convert.ToInt32(per.IdUsuPer(usuario));
                int ide = Convert.ToInt32(per.IdPerUsu(id));
                char est = Convert.ToChar(per.EstPerUsu(usuario));

                //if (id == ide && est!='A' )
                //{
                //    Response.Redirect("~/Clientes/FormNuevosClientes.aspx?id=" + id);
                //}
                ClientScript.RegisterStartupScript(this.GetType(), "alerta", "<script>correcto()</script>");
                Session["Administrador"] = user;
                if (user.des_rol.Equals("Administrador"))
                {
                    Response.Redirect("~/Administradores/Administrador.aspx");
                }
                else if (user.des_rol.Equals("Colaborador") && user.est_usu.Equals(Convert.ToChar("A")))
                {
                    Response.Redirect("~/Colaboradores/Colaborador.aspx");
                }
                
                else if (user.des_rol.Equals("Cliente") && user.est_usu.Equals(Convert.ToChar("A")))
                {
                    Session["Cliente"] = user;
                    Response.Redirect("~/Clientes/TableroClientes.aspx?id=" + id);
                }
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alerta", "<script>inactivo()</script>");
                    txt_usuario.Text = " ";
                    txt_clave.Text = " ";
                }
            }
            else
            {
                if (intentos >=0 && usuario.NoExiste(txt_usuario.Text)==null)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alerta", "<script>noexiste()</script>");
                    txt_usuario.Text = " ";
                    txt_clave.Text = " ";
                }
                else if (intentos>=2)
                {
                    Session["Intentos"] = 0;
                    ClientScript.RegisterStartupScript(this.GetType(), "alerta", "<script>timer()</script>");
                    txt_clave.Text = " ";
                }
                else
                {
                    intentos = intentos + 1;
                    Session["intentos"] = intentos;
                    ClientScript.RegisterStartupScript(this.GetType(), "alerta", "<script>Swal.fire({" +
                       "icon: 'warning'," +
                       " html: '<div><h2> Alerta!</h2></div><div><h4>Contraseña incorrecta, usted ha agotado " + intentos + " intentos</h4></div>'," +
                       "width: '40%'," +
                       "confirmButtonColor: '#EC971F'," +
                       "confirmButtonText: '<h5>Intentar otra vez</h5>'" +
                       "})</script>");
                    txt_clave.Text = " ";
                }
            }
            
        }
    }
}