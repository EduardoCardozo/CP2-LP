using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace ExercicioFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public void Funcionarios()
        {
            /* Criando variáveis e objetos*/
            int qtd = int.Parse(Console.ReadLine()); //Lendo qnt de funcionarios
            string[] nomes, cpfs, datasDeNascimento;
            double[] salarios, novosSalarios;
            DateTime[] datasDeAdmissao;

            /*Instanciando*/

            nomes = new string[qtd];
            cpfs = new string[qtd];
            datasDeNascimento = new string[qtd];
            salarios = new double[qtd];
            novosSalarios = new double[qtd];
            datasDeAdmissao = new DateTime[qtd];

            /* ACHO que isso é feio, por isso ta separado*/
            DateTime[] datasDaTabela = new DateTime[6];
            datasDaTabela[0].AddYears(2014);
            datasDaTabela[1].AddYears(2010);
            datasDaTabela[2].AddYears(2013);
            datasDaTabela[3].AddYears(2000);
            datasDaTabela[4].AddYears(2009);
            datasDaTabela[5].AddYears(1999);

            /*Lendo informações do usuário */
            for (int i = 0; i < qtd; i++)
            {

                cpfs[i] = Console.ReadLine();
                nomes[i] = Console.ReadLine();
                datasDeNascimento[i] = Console.ReadLine();
                datasDeAdmissao[i].AddYears(int.Parse(Console.ReadLine()));
                salarios[i] = double.Parse(Console.ReadLine());



            }
            /*Realizando ajuste de salário */
            for (int j = 0; j < qtd; j++)
            {

                if (datasDeAdmissao[j] >= datasDaTabela[0])
                {
                    novosSalarios[j] = salarios[j] + 423.45;
                }
                else if (datasDeAdmissao[j] >= datasDaTabela[1] && datasDeAdmissao[j] < datasDaTabela[2])
                {
                    novosSalarios[j] = salarios[j] * 9.84 / 100;
                }
                else if (datasDeAdmissao[j] >= datasDaTabela[3] && datasDeAdmissao[j] <= datasDaTabela[4])
                {
                    novosSalarios[j] = salarios[j] + salarios[j] * 16.04 / 100;
                }
                else if (datasDeAdmissao[j] <= datasDaTabela[5])
                {
                    novosSalarios[j] = salarios[j] * 22.06 / 100;
                }
            }
            /*Escrevendo o nome e o salário novo (nao foi especificado oq deveria ser escrito para o usuário) */
            for (int k = 0; k < qtd; k++)
            {
                Console.WriteLine(nomes[k]);              
                Console.WriteLine(novosSalarios[k]);
            }
        }

    }
}