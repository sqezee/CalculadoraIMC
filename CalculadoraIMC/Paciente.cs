using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoIMC
{
    internal class Paciente
    {

        public string nome;

        public double altura, peso;

        public double imc; 


        public Paciente (string nome, double altura, double peso)
        {
            this.nome = nome;
            this.altura = altura;
            this.peso = peso;

        }

        public double CalcularIMC(double altura, double peso)
        {
            double resultado = peso / (altura * altura);

            return resultado;

        }

        public string ClassificacaoIMC(double altura, double peso)
        {
            double imc = peso / (altura * altura);

            string classificacao = string.Empty; 

            if (imc < 16.9)
            {
                classificacao = "Muito abaixo do peso";
            }
            else if (imc >= 17 && imc <= 18.4)
            {
                classificacao = "Abaixo do peso";
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                classificacao = "Peso normal";
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                classificacao = "Acima do peso";
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                classificacao = "Obesidade grau I";
            }
            else if (imc >= 35 && imc <= 40)
            {
                classificacao = "Obesidade grau II";
            }
            else if (imc > 40)
            {
                classificacao = "Obesidade grau III";
            }

            return classificacao; 
        }


    }
}
