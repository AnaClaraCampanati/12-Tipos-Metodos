using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_While
{
    internal class Calculadora
    {

        public static int Somar(int primeiroNumero, int segundoNumero)
        {
            int Somar = primeiroNumero + segundoNumero;
            return Somar;
        }
        public static int Diminuir (int primeiroNumero, int segundoNumero)
        {
            int Diminuir = primeiroNumero - segundoNumero;
            return Diminuir;
        }
        public static int Multiplicar (int primeiroNumero, int segundoNumero)
        {
            int Multiplicar = primeiroNumero * segundoNumero;
            return Multiplicar;
        }
        public static int Dividir (int primeiroNumero, int segundoNumero)
        {
            int Dividir = primeiroNumero / segundoNumero;
            return Dividir;
        }
        
    }
}
