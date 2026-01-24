using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Condição simples
            //int n1 = 10;

            //if (n1 == 10)
            //{
            //    Console.WriteLine("O número é 10");
            //} else
            //{
            //    Console.WriteLine("O número é diferente de 10");
            //}
            #endregion

            #region Condição encadeada

            //int n1 = 25;

            //if (n1 == 0)
            //{
            //    Console.WriteLine("O número é 0");
            //}
            //else if (n1 < 10) {
            //    Console.WriteLine("O número é 10");

            //}
            //else
            //{
            //    Console.WriteLine("O número é Maior ou igual a 10");
            //}

            #endregion

            #region Condição aninhada

            //Console.Write("Digite um número: ");

            //int numero = int.Parse(Console.ReadLine());

            //if (numero > 5)
            //{
            //    Console.Write("O número é maior que 5");

            //    if (numero % 2 == 0)
            //    {
            //        Console.WriteLine(" e também é par!");
            //    }
            //    else
            //    {
            //        Console.WriteLine(" e também é impar!");
            //    }

            //} else
            //{
            //    Console.WriteLine("O número é menor que 5");
            //}
            #endregion

            #region Operador ternário

            int numero = 10;
            string mensagem = mensagem = numero > 5 ? "É maior que 5" : "É menor que 5";

            Console.WriteLine(mensagem);

            #endregion
        }
    }
}
