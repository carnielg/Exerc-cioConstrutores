using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Senha
{
    class Program
    {
        static void Main()
        {
            Senha senha = new Senha(Console.ReadLine());
            Console.WriteLine(senha.VerificarSeguranca());  // Saída: Senha forte.
            Console.ReadKey();
        }
    }
}