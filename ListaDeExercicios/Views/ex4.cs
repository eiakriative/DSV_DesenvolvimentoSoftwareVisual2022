using System;

namespace ListaDeExercicios.Views
{
    public class Ex04
    {
        public static void Renderizar()
        {
            int idade;
            Console.WriteLine("Digite a idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            if (idade <= 13)
            {
                Console.WriteLine("Criança!");
            }
            if (idade > 13 && idade <= 18)
            {
                Console.WriteLine("Adolescente!");
            }
            if(idade > 18 && idade <= 60){
                Console.WriteLine("Adulto!");
            }
            if (idade > 60)
            {
                Console.WriteLine("Idoso!");
            }
        }
    }
}