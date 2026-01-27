using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoDasClasses
{
    //Usando o Delegate
    delegate void Operacao(int num1, int num2);
    internal class Metodos
    {
        // Métodos Simples
        public void Cumprimentar()
        {
            Console.WriteLine("Olá, seja bem vindo!");
        }

        // Método com parâmetros
        public void Somar(int numero, int numero2)
        {
            int resultado = numero + numero2;
            Console.WriteLine($"A soma é: {resultado}");
        }

        // Passagem de parâmetros por valor
        public void AumentarValor(int valor)
        {
            valor += 10;
            Console.WriteLine($"Valor final (por valor) é: {valor}");
        }

        // Passagem de parâmetros por referência
        public void AumentarRef(ref int valor)
        {
            valor += 10;
            Console.WriteLine($"Valor final (por referência) é: {valor}");
        }

        // Métodos com retorno de valores
        public string MontaNome(string nome, string sobrenome)
        {
             //string nomeCompleto = nome + " " + sobrenome;
            
            return nome + " " + sobrenome;
        }

        // Sobrecarga de métodos

        public void Cumprimentar(string nome)
        {
           Console.WriteLine($"Olá {nome}");
        }

        public void Cumprimentar(string nome, int hora)
        {


            string mensagem =
                hora < 12 ? "Bom dia!" :
                hora < 18 ? "Boa tarde!" :
                           "Boa noite";
            Console.WriteLine($"Olá {nome}, {mensagem}");
        }
        

    }
}
