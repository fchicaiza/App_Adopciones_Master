using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;


namespace CapaNegocio
{
    public  class ControladorPersona
    {
        DataClasses1DataContext conn = new DataClasses1DataContext();

        public Sp_BuscarPersonaResult CompararCedula(string cedula)
        {
            var ced = conn.Sp_BuscarPersona().FirstOrDefault(ce => ce.dni_per.Equals(cedula));
            return ced;
        }

        public Sp_CompararUsuPerResult VeificarPersona(string usuario, int id)
        {
           
            var usu = conn.Sp_CompararUsuPer().FirstOrDefault(pe => pe.user_usu.Equals(usuario) && pe.id_usuario.Equals(id));

            return usu;
        }
        public int? IdUsuPer(string  usuario)
        {
            return conn.tbl_usuario.FirstOrDefault(u => u.user_usu == usuario).id_usu;
        }
        public int? IdPerUsu(int id)
        {
            return conn.tbl_personas.FirstOrDefault(i => i.id_usuario == id).id_usuario;
        }
        public char? EstPerUsu(string usuario)
        {
            return conn.Sp_CompararUsuPer().FirstOrDefault(u => u.user_usu == usuario).est_per;
        }
        public string AvatarCliente(string usuario)
        {
            return conn.Sp_CompararUsuPer().FirstOrDefault(u => u.user_usu == usuario).img_per;

        }
        public string NombreCliente(string usuario)
        {
            return conn.Sp_CompararUsuPer().FirstOrDefault(u => u.user_usu == usuario).nom_per;

        }
        public string ApellidoCliente(string usuario)
        {
            return conn.Sp_CompararUsuPer().FirstOrDefault(u => u.user_usu == usuario).ape_per;

        }
    }
}
