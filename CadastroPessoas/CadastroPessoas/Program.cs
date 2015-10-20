using System;
using System.Collections.Generic;
using System.Linq;
using CadastroPessoas;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
/*Crie uma ConsoleApplication orientada a objetos que seja uma interface para cadastrar e consultar registros de pessoas.
O registro de uma pessoa envolve as seguintes informações: Nome, Sobrenome, Peso, Altura e Telefone.
A toda pessoa é atribuido um número identificador único no ato do registro, que não deve ser manipulado pelo programador.
A aplicação deve apresentar um menu com 2 opções: Cadastro e Consulta.O cadastro deve pedir as informaões, salvar em banco e confirmar o salvamento.
A consulta deve funcionar de 2 formas diferentes: Ou pelo primeiro nome ou pelo Id.
Na busca pelo Id há apenas 2 possibilidades: Ou existe ou não.Caso exista, todos os dados devem ser exibidos, caso contrário, o usuário deve ser informado de que não foi encontrado nenhum registro.
Na busca pelo primeiro nome, é possível que haja mais que um registro com o primeiro nome igual.Neste caso, o programa deve apresentar todas os ergistros com o nome pesquisa (Id, nome e sobrenome) para que o usuário possa digitar o Id do que ele quer.
Escolhido o Id, o programa deve exibir todas as informações do registro escolhido.*/
namespace CadastroPessoas
{
    public class Program
    {
        const string queryBase = "INSERT INTO CADASTRO (Nome, Sobrenome, Peso, Altura, Telefone) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')";
        const string mostrarDados = "Nome: {0}\nSobrenome: {1}\nAltura: {2}cm\nPeso: {3}kg\nTelefone: {4}";
        const string strConn = "Server=localhost;Database=test;Uid=root;Pwd=pwroot";
       
        static void Main(string[] args)
        {
            Console.Title = "Cadastro e consulta de Pessoas 1.0";
            Console.WriteLine("Opções:\n1 - Inserir.\n2 - Consultar.\n0 - Sair.");          
            Console.Write("\nOpção: ");

            
 
            int opcao = int.Parse(Console.ReadLine());

            while (opcao != 0)
            {
                switch (opcao)
                {
                    case 1:
                        Inserir();

                        break;
                    case 2:                       
                        Consultar();                               
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
              }               
                LimparConsole();
                opcao = int.Parse(Console.ReadLine());
                
            }

            Console.WriteLine("\nObrigado por utilizar nosso programa!");
        }
        public static void Inserir()
        {
            var pessoa = new Pessoa();
            Cadastro(pessoa);
            string queryInserir = String.Format(queryBase, pessoa.Nome, pessoa.Sobrenome, pessoa.Peso, pessoa.Altura, pessoa.Telefone);          
            BDMethods.Insert(queryInserir);
            Console.WriteLine("Cadastro efetuado com sucesso!");        
        }

        public static void Consultar()
        {
            Console.WriteLine("Opções de Consulta:\n1 - Nome.\n2 - Id.");
            int opcao = int.Parse(Console.ReadLine());
            string nome; string queryConsulta;
            int id = 0;
            switch(opcao)
            {
                case 1:
                    Console.Write("Nome: ");
                    nome = Console.ReadLine();
                    queryConsulta = "SELECT * FROM CADASTRO WHERE nome = '" + nome + "'";
                    BDMethods.Select(queryConsulta);                   
                    break;
                case 2:
                    Console.Write("ID:");
                    id = int.Parse(Console.ReadLine());
                    queryConsulta = "SELECT * FROM Cadastro WHERE id = '" + id + "'";
                    BDMethods.Select(queryConsulta);
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Opção inválida");

            }
                        
        }
              
        public static void LimparConsole()
        {
            Console.WriteLine("Aperte qualquer tecla para continuar!");
            Console.ReadKey();
            Console.Clear();       
            Console.WriteLine("Opções:\n1 - Inserir.\n2 - Consultar.\n0 - Sair.");
            Console.Write("\nOpção: ");
        }
        public static void Cadastro(Pessoa p)
        {
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Sobrenome: ");
            p.Sobrenome = Console.ReadLine();
            Console.Write("Peso: ");
            p.Peso = double.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            p.Altura = double.Parse(Console.ReadLine());
            Console.Write("Telefone: ");
            p.Telefone = Console.ReadLine();
        }
            }
}
