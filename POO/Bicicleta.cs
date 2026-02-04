using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO //Lidando com herança
{
    internal class Bicicleta : Veiculo
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
