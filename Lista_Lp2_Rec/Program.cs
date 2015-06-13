using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
namespace Lista_Lp2_Rec
{
    class Program
    {
        public static void Main(string[] args)
        {
            int exercicio = 0;
            Console.WriteLine("Digite o numero do Exercicio que deseja navegar.");
            exercicio = Convert.ToInt32(Console.ReadLine());
            switch (exercicio)
            {
                case 1:
                    Exercicio1(); 
                    break;
                case 2: 
                    Exercicio2(); 
                    break;
                case 3: 
                    Exercicio3(); 
                    break;
                case 4: 
                    Exercicio4();
                    break;
                case 5:
                    Exercicio5();
                    break;

            }
            
        }
        static void Exercicio1()
        {
            string nome;
            int idade;

            Console.WriteLine("Digite seu nome :");
            nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} tem {1} anos.", nome, idade);


            
        }

        static void Exercicio2()
        {

            string[] resultados = new string[4];
            Circulo r;

            Console.WriteLine("Digite o raio do Circulo/Esfera: ");
            r = new Circulo(int.Parse(Console.ReadLine()));

            resultados[0] = r.Area().ToString();
            resultados[1] = r.Perimetro().ToString();
            resultados[2] = r.Volume().ToString();
            resultados[3] = r.AreaSuperficial().ToString();

            Console.WriteLine("area do círculo :  " + resultados[0].Substring(0, 7));
            Console.WriteLine("perimetro do círculo: " + resultados[1].Substring(0, 7));
            Console.WriteLine("Volume da Esfera : " + resultados[2].Substring(0, 7));
            Console.WriteLine("Area Superficial da Esfera : " + resultados[3].Substring(0, 7));
        }

        static void Exercicio3()
        {
            List<int> quadrados = new List<int>();
            int num = 1, quadrado = 0;
            while (num != 0)
            {
                Console.WriteLine("Digite um numero");
                num = int.Parse(Console.ReadLine());
                quadrado = num * num;
                quadrados.Add(quadrado);


            }
            for (int i = 0; i < quadrados.Count - 1; i++)
            {
                Console.WriteLine(quadrados[i].ToString());
            }
        }
        static void Exercicio4()
        {
            double num = 0, resultado = 0;
            int x = 1;
            while (x != 0)
            {
                Console.WriteLine("Digite um numero entre 1 e 1000:");
                num = double.Parse(Console.ReadLine());

                if (num >= 1 && num <= 1000)
                {
                    for (int i = 1; i <= 1000; i++)
                    {
                        resultado = num * i;
                        Console.WriteLine("{0} x {1} = {2} ", num, i, resultado);
                    }
                }
                else
                {
                    Console.WriteLine("número inválido");
                    
                }
            }

        }
        static string InverterString(string str)//Aprendendo
        {
            int tamanho = str.Length;
            char[] caracteres = new char[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                caracteres[i] = str[tamanho - 1 - i];

            }

            return new string(caracteres);

        }
        static void Exercicio5()
        {
            
            string valor = "";
            int num = 0, aux = 0;

            Console.WriteLine("Digite um numero ");
            num = int.Parse(Console.ReadLine());

            aux = num;

            while (num > 0)
              {
                    valor += Convert.ToString(num % 2);

                    num = num / 2;
             }

                Console.WriteLine("{0}(10) = {1}(2)", aux, InverterString(valor));
           


        }

        
        
        
    }
}
