using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_RepetiçãoEConceitosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio1();
            //Exercicio2();
            //Exercicio3();
            //Exercicio4();
            //Exercicio5();
            //Exercicio6();
            //Exercicio7();
            //Exercicio8();
            //Exercicio9();
            //Exercicio10();
            //Exercicio11();
            //Exercicio12();
            Exercicio13();
        }
        static void Exercicio1()
        {
            for (int i = 0; i < 51; i++)
                Console.WriteLine(i);
        }
        static void Exercicio2()
        {
            for (int i = 1; i < 501; i++)
                Console.WriteLine(i * 5);         
        }
        static void Exercicio3()
        {
            Metade(0);            
        }
        static double Metade(int aux)
        {  
            double num = double.Parse(Console.ReadLine()) / 2;

            if (aux == 9)
            {
                Console.WriteLine(num);
                return num;
            }
            Metade(aux + 1);
            Console.WriteLine(num);
            return num;
            
        }
        static void Exercicio4()
        {
            int soma = 0;
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(i);
                soma += i;
            }
            Console.WriteLine(soma);
        }
        static void Exercicio5()
        {
            int maior = int.MinValue, num;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (num > maior)
                    maior = num;
            }
            Console.WriteLine(maior);
        }
        static void Exercicio6()
        {
            int par = 0, impar = 0;
            for (int i = 0; i < 201; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n % 2 == 0) par++;
                else impar++; 
            }
            Console.WriteLine("{0} pares e {1} impares", par, impar);
        }
        static void Exercicio7()
        {
            double A = double.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine(Potencia(A, B));
        }
        static double Potencia(double A, int B)
        {
            if (B == 1) return A;
            if (A == 1 || A == 0) return A;
            
            return A * Potencia(A, B - 1);
        }
        static void Exercicio8()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine(Resto(A, B));
        }
        static int Resto(int A, int B)
        {
            if (A < B)
                return A;
            return Resto(A - B, B);
            
        }
        static void Exercicio9()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)            
                if (n % i == 0) Console.WriteLine(i);
            
        }
        static void Exercicio10()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
                Console.WriteLine(Fib(i));
        }
        static int Fib(int n)
        {
            if (n == 1 || n == 2) return 1;

            return Fib(n - 1) + Fib(n - 2);
        }
        static void Exercicio11()
        {
            Data data_1 = new Data(31, 12, 1998);
            Console.WriteLine(data_1.toString());

            data_1.AvancarData();
            Console.WriteLine(data_1.toString());
        }
        static void Exercicio12()
        {
            Pedido pedido = new Pedido(1, "Teclado TECHBOM", 10, 55);

            Console.WriteLine(pedido.ValorTotal());
        }
        static void Exercicio13()
        {
            Empregado _1 = new Empregado("Eduardo", "Cardozo", 1000);
            Empregado _2 = new Empregado("Paula", "SDV", 1500);

            Console.WriteLine("{0}: R${1} anuais\n{2}: R${3} anuais", _1.primeiroNome, _1.salario * 12, _2.primeiroNome, _2.salario * 12);

            Console.WriteLine("{0}: R${1} anuais\n{2}: R${3} anuais", _1.primeiroNome, _1.Aumento()* 12, _2.primeiroNome, _2.Aumento() * 12);

        }
    }
}
