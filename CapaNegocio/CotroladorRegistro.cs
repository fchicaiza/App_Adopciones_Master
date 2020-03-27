using System;
using System.Collections.Generic;
using System.Linq;
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
       
    }
}
