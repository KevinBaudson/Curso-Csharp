using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO //Lidando com herança
{
    sealed class Bicicleta : Veiculo // Classe selada que não pode ser herdada
    {
        public override void Acelerar() //Implementando o método abstrato da classe base
        {
            Console.WriteLine("Acelerando a bicicleta!");
        }

        public void Pedalar()
        {
            Console.WriteLine("Pedalando!");
        } 
       
        
    }
}
