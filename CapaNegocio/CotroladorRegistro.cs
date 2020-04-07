using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CotroladorRegistro
    {
        DataClasses1DataContext conn = new DataClasses1DataContext();
        

      public Sp_RegistroResult VerificarRegistro(string cedula)
        {
            var ced = conn.Sp_Registro().FirstOrDefault(cd => cd.dni_per.Equals(cedula));
            return ced;
        }
        public void EnviarClTemp(string mail, string clave)
        {
            MailMessage email = new MailMessage("fchicaiza.g1990@gmail.com", mail);
            SmtpClient usuarios = new SmtpClient();
            usuarios.Port = 587;
            usuarios.EnableSsl = true;
            usuarios.DeliveryMethod = SmtpDeliveryMethod.Network;
            usuarios.UseDefaultCredentials = false;
            usuarios.Credentials = new System.Net.NetworkCredential("fchicaiza.g1990@gmail.com", "1989Y1990g");
            usuarios.Host = "smtp.gmail.com";
            email.Subject = "Clave Temporal";
            email.Body = "Su clave temporal es :" + " " + clave;
            usuarios.Send(email);
        }
        public Sp_BuscarClaveTemResult BuscarClaveTemporal( string clave)
        {
            var cla = conn.Sp_BuscarClaveTem().FirstOrDefault(cl => cl.cltm_usu.Equals(clave));
            return cla;
        }

        public Sp_BuscarClaveTemResult BuscarEmail(string email)
        {
            var ema = conn.Sp_BuscarClaveTem().FirstOrDefault(em => em.ema_usu.Equals(email));
            return ema;
           
        }

        public Sp_BuscarClaveTemResult EnviarCorreo(string correo)
        {
            var corr = conn.Sp_BuscarClaveTem().FirstOrDefault(co => co.ema_usu.Equals(correo));
            return corr;
        }
        public Sp_BuscarClaveTemResult BuscarClaveTem(string temp)
        {
            var ide = conn.Sp_BuscarClaveTem().FirstOrDefault(i=>i.cltm_usu.Equals(temp));
            return ide;

        }
         public Sp_BuscarIdEmailResult BuscarCorreo(string mail) // busca con linq el primer resultado
        {
            var corr = conn.Sp_BuscarIdEmail().FirstOrDefault(co => co.ema_usu.Equals(mail));
            return corr;
        }
     public int?  IdMail(string mail)
        {
            return conn.Sp_BuscarIdEmail().First(li=>li.ema_usu == mail).id_usu;
        }

    }
}
