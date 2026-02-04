using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    //Caso quizessemos herdar de Bicicleta, não seria possível, pois a classe está selada (sealed)
    internal class Caminhonete : Carro
    {
        public bool CabineExtendida { get; set; }
    }
}
