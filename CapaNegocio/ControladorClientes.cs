using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;


namespace CapaNegocio
{
   public class ControladorClientes
    {
        DataClasses1DataContext conn = new DataClasses1DataContext();

        public string IdNombre(int id)
        {
            return conn.tbl_personas.First(idnom => idnom.id_usuario == id).nom_per;
        }

        public string IdApellido(int id)
        {
            return conn.tbl_personas.First(idape => idape.id_usuario == id).ape_per;
        }

        public string IdAvatar(int id)
        {
            return conn.tbl_personas.First(idava => idava.id_usuario == id).img_per;
        }
    }
}
