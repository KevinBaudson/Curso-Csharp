using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecao
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Vetores
            //    int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //    int[] novosNumeros = new int[5];

            //    novosNumeros[0] = 1;
            //    novosNumeros[1] = 15;
            //    novosNumeros[2] = 20;
            //    novosNumeros[3] = 30;
            //    novosNumeros[4] = 45;

            //    string[] nomes = new string[5];

            //    nomes[0] = "Gabriel";
            //    nomes[1] = "Pedro";
            //    nomes[2] = "Daniel";
            //    nomes[3] = "João";
            //    nomes[4] = "Léo";

            //    for (int i = 0; i < novosNumeros.Length; i++)
            //    {
            //        Console.WriteLine(novosNumeros[i]);

            //    }

            #endregion

            int[,] numeros = new int[2, 3];
            numeros[0, 0] = 10;
            numeros[0, 1] = 20;
            numeros[0, 2] = 15;

            numeros[1, 0] = 40;
            numeros[1, 1] = 50;
            numeros[1, 2] = 65;

            Console.Write("Primeira Linha: " + "[" + numeros[0,0] + "]");
            Console.Write("[" + numeros[0,1] + "]");
            Console.Write("[" + numeros[0,2] + "]");

            Console.WriteLine();

            Console.Write("Segunda Linha: " + "[" + numeros[1, 0] + "]");
            Console.Write("[" + numeros[1, 1] + "]");
            Console.Write("[" + numeros[1, 2] + "]");

            Console.WriteLine(); 
            string[,] nomes =
            {
                {"Gabriel", "Danny", "Arthur"},
                {"Flávio", "João", "Pedro"}
            };
            Console.WriteLine(nomes[0,1]);
            Console.ReadKey();
        }
    }
}
