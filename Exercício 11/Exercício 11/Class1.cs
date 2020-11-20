using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_11
{
    class Pessoa
    {
        double peso;
        double altura;
        double r;

        public void SetPeso(double p)
        {
            peso = p;
        }

        public void SetAltura(double p)
        {
            altura = p;
        }

        public double GetPeso()
        {
            return peso;
        }

        public double GetAltura()
        {
            return altura;
        }

        public double GetR()
        {
            return r;
        }

        public double CalcularR()
        {
            r = peso / Math.Pow(altura,2);
            return r;
        }

        public string ExibirMsg()
        {
            string k;

            if (CalcularR() < 20) k = "Abaixo do peso";
            else if (CalcularR() >= 25) k = "Acima do peso";
            else k = "Peso ideal";

            return k;
        }
    }
}
