using System;

namespace ListaDeExercicios.Views
{
    public class Ex03
    {
        public static void Renderizar()
        {
            int numero1, numero2;
            Console.WriteLine("Digite o primeiro número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            if (numero1 > numero2)
            {
                Console.WriteLine("O primeiro número lido é o maior!");
            }
            else
            {
                Console.WriteLine("O segundo número lido é o maior!");
            }
        }
    }
}