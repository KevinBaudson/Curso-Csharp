using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO //Classe base para herança
{
    abstract class Veiculo
    {
        public string Cor { get; set; }
        public string Marca { get; set; }

        public abstract void Acelerar(); //Método abstrato obriga as classes derivadas a implementá-lo



        public void Parar()
        {
            Console.WriteLine("Parou!");
        }
    }
}
