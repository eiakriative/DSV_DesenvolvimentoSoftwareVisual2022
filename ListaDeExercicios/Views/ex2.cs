using System;
using System.Globalization;

namespace ListaDeExercicios.Views
{
    public class Ex02
    {
        const double VALOR_DOLAR_ATUAL = 5.25;
        public static void Renderizar()
        {
            double real, dolar;
            Console.WriteLine("Digite o valor em R$:");
            real = Convert.ToDouble(Console.ReadLine());
            dolar = real / VALOR_DOLAR_ATUAL;
            Console.WriteLine($"Dolar: { dolar.ToString("C", CultureInfo.CreateSpecificCulture("en-US")) } ");
        }
    }
}