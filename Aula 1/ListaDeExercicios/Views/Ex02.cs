using System;
using System.Globalization;

namespace ListaDeExercicios.Views
{
    public class Ex02
    {
        const double VALOR_DOLAR_ATUAL = 5.16;
        const double VALOR_EURO_ATUAL = 5.32;
        const double VALOR_PESOARG_ATUAL = 0.038;

        public static void Renderizar()
        {
            double real, dolar, euro, peso_arg;
            Console.WriteLine("Digite o valor em R$:");
            real = Convert.ToDouble(Console.ReadLine());
            dolar = real / VALOR_DOLAR_ATUAL;
            euro = real / VALOR_EURO_ATUAL;
            peso_arg = real / VALOR_PESOARG_ATUAL;
            Console.WriteLine($"Dolar: { dolar.ToString("C", CultureInfo.CreateSpecificCulture("en-US")) } ");
            Console.WriteLine($"Euro: { euro.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")) } ");
            Console.WriteLine($"Peso Argentino: { peso_arg.ToString("C", CultureInfo.CreateSpecificCulture("es-AR")) } ");
        }
    }
}