using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraBasica
{
    public class Calculadora
    {
        public string fatorConta;
        public double fator1 { get; set; }
        public double fator2 { get; set; }
        public double resultado { get; set; }

        public Calculadora(double fator1, string fatorConta, double fator2)
        {
            this.fatorConta = fatorConta;
            this.fator1 = fator1;
            this.fator2 = fator2;
            this.resultado = resultado;

         
                if (fatorConta.Equals("*"))
                {
                    this.resultado = multiplicacao();
                    Console.WriteLine(resultado);
  
                }
                else if (fatorConta.Equals("-"))
                {
                    this.resultado = subtracao();
                    Console.WriteLine(resultado);
                }
                else if (fatorConta.Equals("/"))
                {
                    this.resultado = divisao();
                    Console.WriteLine(resultado);
                }
                else if (fatorConta.Equals("+"))
                {
                    this.resultado = soma();
                    Console.WriteLine(resultado);
                }
                else
                {
                    Console.WriteLine("Valor do sinal Invalido");
                }
            
        }
        /*Aqui são os métodos*/
        public double soma()
        {
            var resultado = this.fator1 + this.fator2;
            return resultado;

        }
        public double subtracao()
        {
            var resultado = this.fator1 - this.fator2;
            return resultado;
        }
        public double divisao()
        {
            var resultado = this.fator1 / this.fator2;
            return resultado;

        }
        public double multiplicacao()
        {
    
             resultado = this.fator1 * this.fator2;
            return resultado;

        }
    }
}
