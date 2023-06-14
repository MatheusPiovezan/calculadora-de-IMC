using System;

namespace Calculadora_de_IMC
{
    public class PegarIMC
    {
        public float peso;
        public float altura;
        public float calculado;

        public PegarIMC()
        {
            this.peso = 0;
            this.altura = 0;

            do
            {
                Console.Clear();
                Console.Write("Informe seu peso (kg): ");
                while (!float.TryParse(Console.ReadLine(), out this.peso))
                {
                    Console.WriteLine("Insira apenas números");
                }
            } while (this.peso < 1);
            do

            {
                Console.Clear();
                Console.Write("Informe sua altura (metro e cm): ");

                while (!float.TryParse(Console.ReadLine(), out this.altura))
                {
                    Console.WriteLine("Insira apenas números");
                }
            } while (this.altura < 1);

            calcular(this.peso, this.altura);
        }

        public float calcular(float peso, float altura)
        {
            return this.calculado = peso / (altura * altura);
        }
    }

    public class VerificarIMC
    {
        public static void Verificar(float imc)
        {
            if (imc <= 18.5f)
            {
                Console.WriteLine("Você esta abaixo do peso.");
            }
            else if (imc > 18.5f && imc <= 24.9f)
            {
                Console.WriteLine("Você esta no peso ideal (parabéns).");
            }
            else if (imc > 24.9f && imc <= 29.9f)
            {
                Console.WriteLine("Você esta levemente acima do peso.");
            }
            else if (imc > 29.9f && imc <= 34.9f)
            {
                Console.WriteLine("Você esta com obesidade grau I.");
            }
            else if (imc > 34.9f && imc <= 39.9f)
            {
                Console.WriteLine("Você esta com obesidade grau II (severa).");
            }
            else
            {
                Console.WriteLine("Você esta com obesidade grau III (mórbida).");
            }
        }
    }

    class Resultado
    {
        static void Main()
        {
            PegarIMC inf = new PegarIMC();

            Console.Clear();
            Console.WriteLine("Peso: {0}\nAltura: {1}", inf.peso, inf.altura);
            Console.WriteLine("IMC: {0}", inf.calculado.ToString("F"));
            Console.WriteLine("--------------");
            Console.WriteLine(inf.calculado);

            VerificarIMC.Verificar(inf.calculado);
        }
    }
}