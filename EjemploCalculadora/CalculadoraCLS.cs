using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCalculadora
{
    public class CalculadoraCLS
    {
        public double Sumar(double numero1, double numero2)
        {
            return numero1 + numero2;
        }

        public double Restar(double numero1, double numero2)
        {
            return numero1 - numero2;
        }

        public double Multiplicar(double numero1, double numero2)
        {
            return numero1 * numero2;
        }

        public double Dividir(double numero1, double numero2)
        {
            return numero1 / numero2;
        }
    }
}
