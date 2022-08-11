using System;

namespace ListaDeExercicios.Views
{
    public class Ex01
    {
        public static void Renderizar()
        {
            Console.WriteLine("Digite a largura:");
            int largura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a altura:");
            int altura = Convert.ToInt32(Console.ReadLine());
            int area = altura * largura;
            Console.WriteLine($"Área: {area} ");

            // Console.WriteLine("Digite a largura:");
            // double largura = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Digite a altura:");
            // double altura = Convert.ToDouble(Console.ReadLine());
            // double area = altura * largura;
            // Console.WriteLine($"Área: {area} ");
        }
    }
}