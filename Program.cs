using System;
using System.Globalization;

namespace TiposMoedas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Tipo para Moeda*/

            Console.Clear();

            decimal valor = 1123.55m;

            Console.WriteLine(valor.ToString(
                "N",
                CultureInfo.CreateSpecificCulture("pt-BR")
                )

            );
        }
    }
}
