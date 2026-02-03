using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    //Simulando uma classe Conta
    internal class Encapsulamento
    {
        private string _cliente;
        
        public int Saldo
        {
            get
            {
                return (int)_saldo;
            }
            private set
            {
                _saldo = value;
            }
        }
        private double _saldo;
        private double _taxa = 0.10; //taxa encapsulada

        public string Cliente
        {
            get { return _cliente; }
            set
            { 
                if (value != "João" && value != "Logan")
                {
                    _cliente = "Visitante";
                    Saldo = 0; // saldo inicia em zero
                }
                else
                {
                    _cliente = value;
                    _saldo = 100;
                }
            }
        }
        public void Sacar(double valor)
        {
            valor += _taxa; // taxa de saque - manutenção somente dentro do método
            _saldo -= valor;
        }
        public void Depositar(double valor)
        {
           _saldo += valor;
        }

    }
}
