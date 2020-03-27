using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Security.Cryptography;


namespace CapaNegocio
{
   public class ControladorLogin
    {
        DataClasses1DataContext conn = new DataClasses1DataContext();

        public class Encrypt
        {
            public static string GetSHA256(string str)
            {
                SHA256 sha256 = SHA256Managed.Create();
                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] stream = null;
                StringBuilder sb = new StringBuilder();
                stream = sha256.ComputeHash(encoding.GetBytes(str));
                for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
                return sb.ToString();
            }

        }

        public Sp_LoginResult iniciarSesion(string usuario, string clave)
        {
            string ClaveEncr = Encrypt.GetSHA256(clave);
            var usu = conn.Sp_Login().FirstOrDefault(splogin => splogin.user_usu.Equals(usuario) && splogin.pass_usu.Equals(ClaveEncr));

            return usu;
        }

        public Sp_LoginResult NoExiste(string usuario)
        {
            var usu = conn.Sp_Login().FirstOrDefault(ne => ne.user_usu.Equals(usuario));
            return usu;
        }

        public Sp_LoginResult buscarEmail(string email)
        {
            var mail = conn.Sp_Login().FirstOrDefault(em => em.ema_per.Equals(email));
            return mail;
        }
    }
}
