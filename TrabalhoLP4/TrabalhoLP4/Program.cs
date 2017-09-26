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

        public static int[,] Grafo = new int[1000,1000];
        public static bool[] processados = new bool[1000];
        public static int[] distancia = new int[1000];
        

        static void Main(string[] args)
        {
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 0:
                    ListarTurma();
                    break;
                case 1:
                    MenuDijkstra();
                    break;
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
        public static void Dijkstra(int S, int n)
        {
            for (int i = 0; i < n; i++) processados[i] = false;

            for (int i = 0; i < n; i++) distancia[i] = Grafo[S,i];

            processados[S] = true;
            distancia[S] = 0;

            while(true)
            {
                int MaiorD = int.MaxValue;
                int u = -1;

                for(int i = 0; i < n; i++)
                {
                    if(!processados[i] && distancia[i] < MaiorD)
                    {
                        MaiorD = distancia[i];
                        u = i;
                    }
                }

                if (u == -1) break;
                processados[u] = true;

                for (int i = 0; i < n; i++) distancia[i] = min(distancia[i], distancia[u] + Grafo[u, i]);
            }

        }
        public static int min(int a, int b)
        {
            if (a < b) return a;
            return b;
        }
        public static void MenuDijkstra()
        {
            int n = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());

            for (int i = 0; i < 1000; i++)
                for (int j = 0; j < 1000; j++)
                    Grafo[i, j] = int.MaxValue;

            for (int i = 0; i < q; i++)
                Grafo[int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())] = int.Parse(Console.ReadLine());

            Stopwatch sw = new Stopwatch();
            sw.Start();
            Dijkstra(0, n);
            sw.Stop();

            TimeSpan ts = sw.Elapsed;

            Console.WriteLine("{0}:{1}:{2}", ts.Minutes, ts.Seconds, ts.Milliseconds);
        }
    }
}
