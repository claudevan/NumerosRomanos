using System.Collections.Generic;

namespace NumerosRomanos.Conversao
{
    public class Romanos
    {
        private static Dictionary<int, char> SIMBOLOS = new Dictionary<int, char> {
            {1, 'I'},
            {5, 'V'},
            {10, 'X'},
            {50, 'L'},
            {100, 'C'},
            {500, 'D'},
            {1000, 'M'}
        };

        public static string Converter(int numero)
        {
            return MontarNumeroRomano(numero);
        }

        private static string MontarNumeroRomano(int numero)
        {
            var numeroRomano = string.Empty;
            var resto = numero;

            while (numero > 0)
            {
                if(SIMBOLOS.ContainsKey(resto))
                {
                    numeroRomano += SIMBOLOS[resto];

                    numero -= resto;
                    resto = numero;
                }
                else
                {
                    resto--;
                }
            }

            return numeroRomano;
        }
    }
}
