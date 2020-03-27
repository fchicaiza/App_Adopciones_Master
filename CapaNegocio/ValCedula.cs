using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CapaDatos;
using CapaNegocio;

namespace Validaciones
{
    public class ValCedula
    {

        public bool ValidarCedula(String TxtNumeros)
        {
            int Numerico;
            var total = 0;
            int TamanoCedula = 10;
            int[] coeficientes = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            int provincia1 = 24;
            int Verificador = 6;

            if (int.TryParse(TxtNumeros, out Numerico) && TxtNumeros.Length == TamanoCedula)
            {
                int provincia = Convert.ToInt32(string.Concat(TxtNumeros[0], TxtNumeros[1], string.Empty));
                var digitosTres = Convert.ToInt32(TxtNumeros[2] + string.Empty);

                if ((provincia > 0 && provincia <= provincia1) && digitosTres < Verificador)
                {
                    var digitoVerificador = Convert.ToInt32(TxtNumeros[9] + string.Empty);
                    for (var k = 0; k < coeficientes.Length; k++)
                    {
                        var valor = Convert.ToInt32(coeficientes[k] + string.Empty) *
                                    Convert.ToInt32(TxtNumeros[k] + string.Empty);
                        total = valor >= 10 ? total + (valor - 9) : total + valor;


                    }
                    var digitoVerificadorObtenido = total >= 10 ? (total % 10) != 0 ?
                                                10 - (total % 10) : (total % 10) : total;
                    return digitoVerificadorObtenido == digitoVerificador;
                }
                return false;
            }
            return false;
        }

        public bool RucPersonaNatural(String ruc)
        {
            long isNumeric;
            const int tamanoLongitudRuc = 13;
            const string establecimiento = "001";
            if (long.TryParse(ruc, out isNumeric) && ruc.Length.Equals(tamanoLongitudRuc))
            {
                var numeroProvincia = Convert.ToInt32(string.Concat(ruc[0] + string.Empty, ruc[1] + string.Empty));
                var personaNatural = Convert.ToInt32(ruc[2] + string.Empty);
                if ((numeroProvincia >= 1 && numeroProvincia <= 24) && (personaNatural >= 0 && personaNatural < 6))
                {
                    return ruc.Substring(10, 3) == establecimiento && ValidarCedula(ruc.Substring(0, 10));
                }
                return false;
            }
            return false;
        }
    }
}