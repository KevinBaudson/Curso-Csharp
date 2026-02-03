// See https://aka.ms/new-console-template for more information
using POO;
using System.ComponentModel;


#region Encapsulamento
Encapsulamento Conta = new Encapsulamento();

Conta.Cliente = "João";
//conta.Saldo = 100;
Conta.Depositar(1000);

// Operação de depósito e saque
double valorDeposito = 1000;
Conta.Depositar(valorDeposito);

double valorSaque = 500;
Conta.Sacar(valorSaque);

// Resultado Saldo Atual
Console.WriteLine($"Cliente: {Conta.Cliente}");
Console.WriteLine($"Saldo: {Conta.Saldo}" );

#endregion

#region Herança

    //Carro carro = new Carro();
    //Bicicleta bicicleta = new Bicicleta();
    //carro.LigarMotor();
    //bicicleta.Pedalar();

    //carro.Acelerar();
    //bicicleta.Parar();

#endregion