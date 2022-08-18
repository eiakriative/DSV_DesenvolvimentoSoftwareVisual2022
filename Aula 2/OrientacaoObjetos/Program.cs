using System;

namespace OrientacaoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usr = new Usuario();
            usr.Nome = "Joel";
            Console.WriteLine($"Nome do usuario { usr.Nome }");
            Console.WriteLine("----------------------------------");
            Produto prod = new Produto();
            prod.Nome = "Tenis Nike";
            prod.Preco = 200.50;
             Console.WriteLine($"Nome: { prod.Nome } \nPreço: { prod.Preco}");
            Console.WriteLine("----------------------------------");
            Produto prod2 = new Produto
            {
                Nome = "Pepsi",
                Preco = 5
            };
             Console.WriteLine($"Nome: { prod2.Nome } \nPreço: { prod2.Preco}");
             Console.WriteLine("----------------------------------");
        }
    }
}
