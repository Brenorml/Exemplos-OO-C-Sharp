using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploPOO.Interfaces;

namespace ExemploPOO.Models
{
    public class Calculadora : ICalculadora
    {

        //Como mudamos o método na interface ICalculadora para que ele retorne esta operação, não é mais necessária declara-la aqui.
        // A não ser que seja necessário sobrescrever o método padrão da interface para uma especificidade aqui.
        // public int Dividir(int num1, int num2)
        // {
        //     return num1 / num2;
        // }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Somar(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}