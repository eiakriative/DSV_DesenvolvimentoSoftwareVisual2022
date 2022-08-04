using System;

namespace ListaDeExercicios.Views
{
    public class Ex05
    {
        public static void Renderizar()
        {
            int n, a = 0, b = 0, c = 1;
            Console.Write("Digite um valor inteiro positivo: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                a = b;
                b = c;
                c = a + b;
                Console.Write(a+" ");
            }
        }
    }
}