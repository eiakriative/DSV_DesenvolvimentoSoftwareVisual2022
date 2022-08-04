using System;

namespace ListaDeExercicios.Views
{
    class Program
    {
        static void Main(string[] args)
        {
            int ex;
           
            Console.Write("Digite um exercicio entre 1 a 6: ");
            ex = Convert.ToInt32(Console.ReadLine());

            switch (ex)
            {
                case 1:
                    Ex01.Renderizar();
                    break;
                case 2:
                    Ex02.Renderizar();
                    break;
                case 3:
                    Ex03.Renderizar();
                    break;
                case 4: 
                    Ex04.Renderizar();
                    break;
                case 5:
                    Ex05.Renderizar();
                    break;
                case 6:
                    Ex06.Renderizar();
                    break;
                default:
                    break;
            }
        }
    }
}
