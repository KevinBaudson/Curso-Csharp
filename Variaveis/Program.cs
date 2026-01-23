using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    internal class Program
    {
        enum Notas
        {
            Minimo = 10,
            Media = 20,
            Maxima = 30
        }

        struct Pessoa
        {
            public String nome;
            public int idade;
            public double altura;
        }
        static void Main(string[] args)
        {
            #region Numericas Integrais
            //// Integral assinado
            //sbyte num1 = 10; // 8 bits, de -120 a 127
            //short num2 = 20; // 16 bits, -32.768 a 32.767
            //int num3 = 30; // 32 bits, -2.147.483.648 a 2.147.483.647
            //long num4 = 40; // 64 bits

            //// Integral sem sinal
            //byte num5 = 10; // 8 bits, intervalo de 0 a 255
            //ushort num6 = 20; // 16 bits, 0 a 65.535
            //uint num7 = 30; // 32 bits. 0 a 4.294.967.295
            //ulong num8 = 40L; // 64 bits  

            //sbyte numero;
            //numero = 100;

            //Console.WriteLine(numero);
            //Console.ReadKey();
            #endregion

            #region Números reais
            //float real1 = 100.75f; // 32 bit
            //double real2 = 500.754; // 64 bits
            //decimal real3 = 752538.457m; // 128bits


            //double valor;
            //valor = 500;
            //valor = real1;
            #endregion

            #region Caractere

            //char letra = 'a'; // apenas um caractere ou o código dele
            //char letra2 = '\u0061';

            #endregion

            #region Boolean
            //bool verificar = false;
            //verificar = true;

            #endregion

            #region String (cadeia de caracteres)
            //string texto = "Nome: Kevin \n Idade: 32 anos";
            //string texto2 = @"Nome: Kevin \n Idade: 32 anos"; // remove os caracteres especiais como a quebra de linha
            //string mensagem = null;
            //mensagem = texto;
            //Console.WriteLine(mensagem);
            //Console.ReadKey();

            #endregion

            #region Tipo Implicito VAR

            //var valor = 150; // passa a ser do tipo inteiro

            #endregion

            #region Tipo Object (Base para todos os tipos)
            //object obj = false;
            //obj = 100;
            //obj = "Kevin";
            #endregion

            #region Constantes
            //const double pi = 3.1415; // O valor precisa ser dado na iniciação
            #endregion

            #region Tipo Enum
            // Notas notasAlunos = Notas.Media;
            #endregion

            #region Tipo struct
            //Pessoa p1 = new Pessoa();
            //p1.nome = "kevin";
            //p1.idade = 32;
            //p1.altura = 1.68;


            //Pessoa p2 = new Pessoa()
            //{
            //    nome = "Pedro",
            //    idade = 25,
            //    altura = 1.50
            //};

            //Console.WriteLine("Nome:" + p1.nome + "\n" + "Idade: " + p1.idade);
            //Console.ReadKey();
            #endregion


        }
    }
}
