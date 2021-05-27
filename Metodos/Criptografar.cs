using System;
using System.Collections.Generic;
using System.Text;

namespace CriptografiaCesar.Util
{
    public class Criptografar
    {
        public string CriptografarTexto(string entrada, int chave)
        {
            string saida = "";

            for (int i = 0; i < entrada.Length; i++)
            {
                if (entrada[i] == ' ')
                {
                    saida += ' ';
                    continue;
                }
                    
                var ASCII = Convert.ToInt32(entrada[i]); 
                var ASCIIC = ASCII + chave; 
                ASCIIC = new CriptografiaCesar.Util.VerificaValor().Verificar(ASCIIC);

                saida += Convert.ToChar(ASCIIC);
            }

            return saida;
        }
    }
}
