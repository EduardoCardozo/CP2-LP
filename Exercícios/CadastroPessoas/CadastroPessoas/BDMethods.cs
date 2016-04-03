using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace CadastroPessoas
{
    public static class BDMethods
    {
        const string strConn = "Server=localhost;Database=test;Uid=root;Pwd=pwroot";
        const string mostrarDados = "Nome: {0}\nSobrenome: {1}\nAltura: {2}cm\nPeso: {3}kg\nTelefone: {4}";
        static List<Pessoa> pessoas = new List<Pessoa>();

        public static void Select(string qr)
        {
            try
            {
                Pessoa p = new Pessoa();
                var conn = new MySqlConnection(strConn);
                var command = new MySqlCommand()
                {
                    Connection = conn,
                    CommandText = qr
                };
                conn.Open();
                MySqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {                       
                        p.Id = dr.GetInt32(0);
                        p.Nome = dr.GetString(1);
                        p.Sobrenome = dr.GetString(2);
                        p.Peso = dr.GetDouble(3);
                        p.Altura = dr.GetDouble(4);
                        p.Telefone = dr.GetString(5);
                        pessoas.Add(p);
                                        
                    }
                    if (pessoas.Count > 1)
                    {
                        Console.WriteLine("Pesquisa:\n");
                        for (int i = 0; i < pessoas.Count; i++)
                        {
                            Console.WriteLine("ID: {0}\nNome:{1}\nSobrenome: {2}", pessoas[i].Id, pessoas[i].Nome, pessoas[i].Sobrenome);
                        }
                        Console.Write("Escolha o ID:");
                        int id = int.Parse(Console.ReadLine());
                        for (int i = 0; i < pessoas.Count; i++)
                        {
                            if (pessoas[i].Id == id)
                            {
                                Console.WriteLine(String.Format(mostrarDados, p.Nome, p.Sobrenome, p.Peso, p.Altura, p.Telefone));
                            }
                        }
                    }
                    else
                        Console.WriteLine(String.Format(mostrarDados, p.Nome, p.Sobrenome, p.Peso, p.Altura, p.Telefone));
                }
                else
                    Console.WriteLine("ID inexistente!");
                conn.Close();
            
            }
            catch (Exception Eex)
            {
                Console.WriteLine(Eex.Message);
            }

        }
        public static void Insert(string qr)
        {
            try
            {
                var conn = new MySqlConnection(strConn);
                var command = new MySqlCommand()
                {
                    Connection = conn,
                    CommandText = qr
                };
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception Eex)
            {
                Console.WriteLine(Eex.Message);
            }
        }
    }
}
