using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial) //Contructor 
        {
            //Whena instantiating gets: numeroConta and saldoInicial
            NumeroConta = numeroConta; 
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; } //property
        private decimal saldo; //attribute

        public void Sacar(decimal valor) //Method - receives valor and then reduces this value from saldo
        {
            if(saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso");
            }
            else
            {
                Console.Write("Valor desejado é maior que o saldo disponível");
            }            
        }
        public void ExibirSaldo() //Method to show saldo value
        {
            Console.WriteLine($"Seu saldo disponível é: {saldo}");
        }
    }
}