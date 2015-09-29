using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRH
{
    class Program
    {

       const string PrintGerente = "Nome: {0}\n" +
                                           @"CPF: {1:000\.000\.000\-00}" + "\n"+
                                           @"Data de Nascimento: {2:00\/00\/0000}" + "\n"+
                                           "Matricula : {3}\n" +
                                           "Salario: R${4}\n" +
                                           "Area de Gerencia : {5}\n" +
                                           "Vale Alimentação : R${6} ";


        const string PrintEmpregado = "Nome: {0}\n" +
                                           @"CPF: {1:000\.000\.000\-00}" + "\n" +
                                           @"Data de Nascimento: {2:00\/00\/0000}" + "\n" +
                                           "Matricula : {3}\n" +
                                           "Salario: R${4}\n" +                                     
                                           "Vale Alimentação : R${6} ";
        const string PrintTerceirizado = "Nome: {0}\n" +
                                           @"CPF: {1:000\.000\.000\-00}" + "\n" +
                                           @"Data de Nascimento: {2:00\/00\/0000}" + "\n" +
                                           "Matricula : {3}\n" +
                                           @" CNPJ: {4:00\.000\.000\/0000\-00}";


                                           


        static void Main(string[] args)
        {
            List<Empregado> empregados = new List<Empregado>();
            List<Gerente> gerentes = new List<Gerente>();
            List<Terceirizado> terceirizados = new List<Terceirizado>(); 
            int i = 1, numeroFuncionario = 0;
            
            while (i != 0)
            {
                Console.WriteLine("Digite 0 para exibir a folha de pagamento ou 1 para adicionar um funcionario!!");
                i = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    Console.WriteLine("Digite 1 para Empregado, 2 para Gerente ou 3 para Terceirizado");
                    numeroFuncionario = int.Parse(Console.ReadLine());
                    switch (numeroFuncionario)
                    {
                        case 1:
                            var empregado = new Empregado()
                            {
                                Nome = Console.ReadLine(),
                                Cpf = long.Parse(Console.ReadLine()),
                                DataDeNacimento = DateTime.Parse(Console.ReadLine()),
                                Matricula = Console.ReadLine(),
                                Salario = decimal.Parse(Console.ReadLine())
                            };
                            empregados.Add(empregado);
                            break;
                        case 2:
                            var gerente = new Gerente()
                            {
                                Nome = Console.ReadLine(),
                                Cpf = long.Parse(Console.ReadLine()),
                                DataDeNacimento = DateTime.Parse(Console.ReadLine()),
                                Matricula = Console.ReadLine(),
                                Salario = decimal.Parse(Console.ReadLine()),
                                AreaDeGerencia = Console.ReadLine(),
                                ValorAdicionalSalario = decimal.Parse(Console.ReadLine()),
                                

                            };                            
                            gerentes.Add(gerente);
                            break;
                        case 3:
                            var terceirizado = new Terceirizado()
                            {
                                Nome = Console.ReadLine(),
                                Cpf = long.Parse(Console.ReadLine()),
                                DataDeNacimento = DateTime.Parse(Console.ReadLine()),
                                Matricula = Console.ReadLine(),
                                Salario = decimal.Parse(Console.ReadLine()),
                                Cnpj = long.Parse(Console.ReadLine()),
                                
                            };
                            terceirizados.Add(terceirizado);
                            break;                       
                    }
                    
                }
                else
                    i = 0;
                
            }


            Console.WriteLine("'''''''''FOLHA DE PAGAMENTO''''''");
            //decimal salarioTotal = 0;

            Console.WriteLine("Gerentes");
            foreach (var gerente  in gerentes)
            {
                //salarioTotal += gerente.SalarioTotal;
                Console.WriteLine(PrintGerente, gerente.Nome.ToUpper(), gerente.Cpf, gerente.DataDeNacimento, gerente.Matricula,
                                  gerente.Salario, gerente.AreaDeGerencia, gerente.ValeAlimentacao);
                
                    
            }

            Console.WriteLine("Terceirizados");
            foreach (var terceirizado in terceirizados)
            {
                Console.WriteLine(PrintTerceirizado, terceirizado.Nome.ToUpper(), terceirizado.Cpf, terceirizado.DataDeNacimento,
                                  terceirizado.Matricula, terceirizado.Cnpj);
                
            }

            Console.WriteLine("Empregados");
            foreach (var empregado in empregados )
            {
                
                Console.WriteLine(PrintEmpregado, empregado.Nome.ToUpper(), empregado.Cpf, empregado.DataDeNacimento, empregado.Matricula,
                                  empregado.Salario, empregado.ValeAlimentacao);
                
            }

            




           
         }
    }
}
