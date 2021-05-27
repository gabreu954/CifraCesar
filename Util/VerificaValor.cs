using System;
using System.Collections.Generic;
using System.Text;

namespace CriptografiaCesar.Util
{
    public class VerificaValor
    {
        public int Verificar(int valor)
        {

            while (valor > 122 || valor < 97)
            {
                if (valor > 122)
                {
                    valor = 96 + (valor - 122);
                }
                if (valor < 97)
                {
                    valor = 123 - (97 - valor);
                }
            }
            return valor;

        }
    }
}
