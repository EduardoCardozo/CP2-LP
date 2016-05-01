using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_DecisãoeAlgoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            Desafio();         
        }
        public static void Exercicio1()
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0) Console.WriteLine("{0} é par!", n);
            else Console.WriteLine("{0} é ímpar!", n);
        }
        public static void Exercicio2()
        {
            int idade = int.Parse(Console.ReadLine());
            if (idade < 18) Console.WriteLine("Menor de idade!");
            else Console.WriteLine("Maior de Idade!");        
        }
        public static void Exercicio3()
        {
            double temperatura = double.Parse(Console.ReadLine());
            if (temperatura < 37) Console.WriteLine("Não está com febre!");
            else Console.WriteLine("Está com febre!");         
        }
        public static void Exercicio4()
        {
            string sexo = Console.ReadLine().ToUpper();
            string genero;
            if (sexo == "F") genero = "Feminino";
            else genero = "Masculino";

            Console.WriteLine("Está pessoa declara-se como sendo do sexo {0}!", genero);         
        }
        public static void Exercicio5()
        {
            string letra = Console.ReadLine().ToLower();
            bool ehvogal = true;

            if (letra != "a" && letra != "e" && letra != "i" && letra != "o" && letra != "u")
                ehvogal = false;

            if (ehvogal) Console.WriteLine("é vogal!");
            else Console.WriteLine("não é vogal!");
                         
        }
        public static void Exercicio6()
        {
            string sabor = Console.ReadLine();
            int qtdBolas = int.Parse(Console.ReadLine());
            if (sabor == "C")
                if (qtdBolas < 3) Console.WriteLine("5% de desconto");
                else Console.WriteLine("10% de desconto");      
        }
        public static void Exercicio7()
        {
            double nota, media;
            nota = double.Parse(Console.ReadLine());
            media = nota * 3;
            nota = double.Parse(Console.ReadLine());
            media += nota * 3;
            nota = double.Parse(Console.ReadLine());
            media = (media + nota * 4) / 10;

            if (media >= 7) Console.WriteLine("Aprovado!");
            else if (media > 3) Console.WriteLine("Recuperação!");
            else Console.WriteLine("Reprovado!");


            /*Outro método de ler as notas (aprendendo)

            Console.WriteLine("Digite as notas separando-as por um espaço ' '");
            string prenotas = Console.ReadLine();
            string[] notas = prenotas.Split(' ');
            double media, nota = double.Parse(notas[0]));
            media = nota * 3;
            nota = double.Parse(notas[1]));
            media += nota * 3;
            nota = double.Parse(notas[2]));
            media = (media + nota * 4) /10; 

            if (media >= 7) Console.WriteLine("Aprovado!");
            else if (media > 3) Console.WriteLine("Recuperação!");
            else Console.WriteLine("Reprovado!"); */

        }
        public static void Exercicio8()
        {
            int idade = int.Parse(Console.ReadLine());
            int menoridade = idade;

            idade = int.Parse(Console.ReadLine());
            if (idade < menoridade) menoridade = idade;

            idade = int.Parse(Console.ReadLine());
            if (idade < menoridade) menoridade = idade;

            Console.WriteLine(menoridade);

            
        }
        public static void Exercicio9()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
                             
            if (x > 0)
                if (y > 0) Console.WriteLine("1º Quadrante.");
                else if (y < 0) Console.WriteLine("4º Quadrante.");
                else Console.WriteLine("Ponto na Reta X entre o 1º e 4º Quadrantes.");
            else if (x < 0)
                if (y > 0) Console.WriteLine("2º Quadrante.");
                else if (y < 0) Console.WriteLine("3º Quadrante.");
                else Console.WriteLine("Ponto na reta X entre o 2º e 3º Quadrante.");
            else
                if (y > 0) Console.WriteLine("Ponto na reta Y entre o 1º e 2º Quadrante.");
                else if (y < 0) Console.WriteLine("Ponto na reta Y entre o 3º e 4º Quadrante.");
                else Console.WriteLine("Ponto na origem");
        }
        public static void Exercicio10()
        {
            string matricula = Console.ReadLine();
            string mesPagamento = "";
            char[] x = matricula.ToCharArray();

            switch (x[x.Length - 1])
            {
                case '0':mesPagamento = "Janeiro"; break;
                case '1':mesPagamento = "Fevereiro"; break;
                case '2':mesPagamento = "Março"; break;
                case '3':mesPagamento = "Abril"; break;
                case '4':mesPagamento = "Maio"; break;
                default:mesPagamento = "Junho"; break;
            }
        }
        public static void Desafio()
        {
            int dia = int.Parse(Console.ReadLine());
            string mes = Console.ReadLine();
            int ano = int.Parse(Console.ReadLine());            
            int numeroDiaDaSemana, numeroDoMes; string diaSemana = "";
            ano = ano - 1900;
            int diasfev = ano / 4;
            switch (mes.ToLower())
            {
                case "janeiro":
                case "outubro": numeroDoMes = 0; break;
                case "setembro":
                case "dezembro":numeroDoMes = 5; break;
                case "junho":numeroDoMes = 4; break;
                case "Maio": numeroDoMes = 1; break;
                case "julho":
                case "agosto":
                case "abril": numeroDoMes = 6; break;
                default: numeroDoMes = 3; break;
            }

            numeroDiaDaSemana = (dia + diasfev + ano + numeroDoMes) % 7;

            switch (numeroDiaDaSemana)
            {
                case 0: diaSemana = "Domingo"; break;
                case 1: diaSemana = "Segunda-Feira"; break;
                case 2: diaSemana = "Terça-Feira"; break;
                case 3: diaSemana = "Quarta-Feira"; break;
                case 4: diaSemana = "Quinta-Feira"; break;
                case 5: diaSemana = "Sexta-Feira"; break;
                case 6: diaSemana = "Sábado"; break;
               
            }

            Console.WriteLine("{0}, {1} de {2} de {3}", diaSemana, dia, mes, ano + 1900);

        }
        
    }
}
