using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematica
{
    internal class Program
    {
        // Usando o delegate

        delegate void Operacao(int num1, int num2);
        static void Main(string[] args)
        {
            Delegate d = new Delegate();

            Operacao conta = null;

            conta += d.Somar;

            conta(10, 45);

            Console.ReadKey();

        }
    }
}
