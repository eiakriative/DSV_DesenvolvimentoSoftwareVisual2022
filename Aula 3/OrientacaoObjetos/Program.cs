using System;

namespace OrientacaoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usr = new Usuario();
            usr.setNome("Joel");
            Console.WriteLine($"Nome do usuario { usr.getNome() }");
            Console.WriteLine("----------------------------------");

        }
    }
}
