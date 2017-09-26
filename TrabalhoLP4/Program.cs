using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.Timers;


namespace TrabalhoLP4
{
    class Program
    {
        public enum operacao { ListarTurma, Cronometro}
        static void Main(string[] args)
        {
            int op = 1;
            switch ((int)op)
            {
                case 0:
                    ListarTurma();
                    break;
                case 1:
                    Cronometro();
                    break;
            }
        }
        protected static void myHandler(object sender, ConsoleCancelEventArgs args)
        {
            args.Cancel = true;
        }


        public static void Cronometro()
        {
            Stopwatch x = new Stopwatch();
            x.Start();

            while (true)
            {
                Console.WriteLine(x.Elapsed);

                Thread.Sleep(1);
                Console.Clear();
            }
        }
        public static void ListarTurma()
        {

            SortedDictionary<int, string> turma = new SortedDictionary<int, string>();

            int qtdAlunos = int.Parse(Console.ReadLine());
            
            while (qtdAlunos > 0)
            {
                int numero = int.Parse(Console.ReadLine());
                string name = Console.ReadLine();

                turma.Add(numero, name);
                qtdAlunos--;
            }

            foreach (KeyValuePair<int, string> x in turma)
                Console.WriteLine(x.Key + " " + x.Value);
        }
    }
}
