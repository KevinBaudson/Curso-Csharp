using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Carro : Veiculo // Lidando com herança
    {
        public int  VelocidadeMaxima { get; set; }

        public override void Acelerar() //Implementando o método abstrato da classe base
        {
            Console.WriteLine("O carro está acelerando");
        }

        public void LigarMotor()
        {
            Console.WriteLine("O carro ligou o motor!");
        }
       

    }
}
