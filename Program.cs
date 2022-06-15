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

            decimal valor = 1123.2m;

            Console.WriteLine(valor.ToString("p",CultureInfo.CreateSpecificCulture("pt-BR")));//porcentagem
            Console.WriteLine(valor.ToString("N",CultureInfo.CreateSpecificCulture("pt-BR")));//formata para moeda só que sem a sigla 
            Console.WriteLine(valor.ToString("f",CultureInfo.CreateSpecificCulture("pt-BR")));//adiciona casa decimal, aumentando a precisão
            Console.WriteLine(valor.ToString("C",CultureInfo.CreateSpecificCulture("pt-BR")));//padrão moeda
        }
    }
}
