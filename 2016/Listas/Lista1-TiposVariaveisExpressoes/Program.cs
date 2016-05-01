using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
        public static void Exercicio_1()
        {
            /* Math.Sqrt -> Recebe um número real como parâmetro e devolve
            a raiz quadrada desse número.*/ 
            double raiz = Math.Sqrt(81);// raiz = 9.

            /* Math.Abs -> Recebe um número real como parâmetro e devolve
            o módulo desse número (ou valor absoluto).*/
            double modulo = Math.Abs(-123);// modulo = 123.

            /* Math.Truncate -> Recebe um número decimal como parâmetro e devolve
            a parte inteira desse número.*/
            double inteiro = Math.Truncate(123.456);// inteiro = 123.

            /* Math.Round -> Recebe um valor e arredonda para o numero inteiro
            mais próximo.*/
            inteiro = Math.Round(1.2);// inteiro = 1
               
        }
        public static void Exercicio_2()
        {
            /* NA FOLHA */
        }
        public static void Exercicio_3()
        {
             /*9 / 2 * 3 + 1 = 14,5
              9 / (2 * 3) + 1 = 2,5
              9 / (2 * 3 + 1) = 1,28
              (9 / 2) * 3 + 1 = 14,5*/
        }
        public static void Exercicio_4()
        {
            double a = 0, b = 0, c = 0, n = 0, formula;
            //a
            formula = Math.Pow((n + 1), 2) / (a - c);
            //b
            formula = (-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
            //c
            formula = ((a + b) * (a - b)) / a * b;
            //d
            formula = 3 * Math.Sqrt((a + 2) / (Math.Sqrt(a) + 2));
            //e
            formula = (Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2)) / (a + b + c); 
        }
        public static void Exercicio_5()
        {
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine(idade *= 365);          
        }
        public static void Exercicio_6()
        {
            
            decimal total = decimal.Parse(Console.ReadLine());
            decimal tot = total;
            decimal pagar = Math.Truncate(total) / 3;
            Console.WriteLine("Carlos e André: R${0} cada.\nFelipe: R${1}.", Math.Truncate(pagar), total - (Math.Truncate(pagar) * 2));
        }
        public static void Exercicio_7()
        {
            double celsius = 1;
            while (celsius != 0)// No RJ não faz zero grau!
            {
                celsius = double.Parse(Console.ReadLine());
                double fahrenheit = 9 * celsius / 5 + 32;
                Console.WriteLine(fahrenheit + "ºF"); 
            }
        }
        public static void Exercicio_8()
        {
            double precoKG = double.Parse(Console.ReadLine());
            double pesoTara = double.Parse(Console.ReadLine());
            double pesoComida = double.Parse(Console.ReadLine()) - pesoTara;

            Console.WriteLine(pesoComida * 1000);
            Console.WriteLine(pesoComida * precoKG);

        }
        public static void Exercicio_9()
        {
            decimal[] salarios = new decimal[3];
            salarios[0] = decimal.Parse(Console.ReadLine());           
            salarios[1] = Math.Round(salarios[0] + 0.15M * salarios[0], 2);
            salarios[2] = Math.Round(salarios[1] - 0.08M * salarios[1], 2);

            Console.WriteLine("Salario inicial: R${0} \nSalario reajustado: R${1} \nSalario final: R${2}", salarios[0], salarios[1], salarios[2]);
        }
        public static void Exercicio_10()
        {
            int unidade, dezena, centena, numero;

            numero = int.Parse(Console.ReadLine());
            unidade = numero % 10;
            numero /= 10;
            dezena = numero % 10;
            numero /= 10;
            centena = numero % 10;

            Console.WriteLine("Centena: {0} / Dezena: {1} / Unidade: {2}", centena, dezena, unidade);
            
        }
        public static void Exercicio_11()
        {
            int _1real = int.Parse(Console.ReadLine());
            double _50cents = double.Parse(Console.ReadLine()) * 0.5;
            double _25cents = double.Parse(Console.ReadLine()) * 0.25;
            double _10cents = double.Parse(Console.ReadLine()) * 0.1;
            double _5cents = double.Parse(Console.ReadLine()) * 0.05;
            double _1cents = double.Parse(Console.ReadLine()) * 0.01;
            double total = _1real + _50cents + _25cents + _10cents + _5cents + _1cents;
            Console.WriteLine(total);
        }
        public static void Exercicio_12()
        {
            double minha_sombra = double.Parse(Console.ReadLine());
            double sombra_predio = double.Parse(Console.ReadLine());
            double minha_altura = double.Parse(Console.ReadLine());
            double altura_predio = (minha_altura * sombra_predio) / minha_sombra;
            Console.WriteLine(altura_predio);
                
        }
        public static void Exercicio_13()
        {
            double v0 = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
            double delta_s = double.Parse(Console.ReadLine());

            double v = v0 * v0 + 2 * a * delta_s;
            v *= v;
            Console.WriteLine(v);
        }
        public static void Exercicio_14()
        {
            double _preço = double.Parse(Console.ReadLine());
            double altura = double.Parse(Console.ReadLine()) / 100;
            double largura = double.Parse(Console.ReadLine()) / 100;
            double comprimento = double.Parse(Console.ReadLine()) / 100;
            double volume = altura * largura * comprimento;
            volume = volume - 0.15 * volume;
            Console.WriteLine(volume * _preço);
        }
    }
}
