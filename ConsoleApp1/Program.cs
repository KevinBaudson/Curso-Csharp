using ClassesObjetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ClassesObjetos
            //MinhaClasse mClasse = new MinhaClasse();
            //MinhaClasse m2 = null;

            //OutraClasse outra = new OutraClasse();

            #endregion

            Pessoa p1 = new Pessoa();
            p1.nome = "João";
            p1.sobrenome = "Silva";
            p1.anoNascimento = 1980;

            Pessoa p2 = new Pessoa()
            {
                nome = "Arthur",
                sobrenome = "Maciel",
                anoNascimento = 2011
            };
            Console.WriteLine("Pessoa 1:" + p1.nome);
            Console.WriteLine("Pessoa 1:" + p1.sobrenome);
            Console.WriteLine("Pessoa 1:" + p1.anoNascimento);

            Console.WriteLine("--------------------------");

            Console.WriteLine("Pessoa 2:" + p2.nome);
            Console.WriteLine("Pessoa 2:" + p2.sobrenome);
            Console.WriteLine("Pessoa 2:" + p2.anoNascimento);

            Console.ReadKey();

        }
    }

    class MinhaClasse
    {

    }
}
