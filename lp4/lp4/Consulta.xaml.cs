using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;


namespace lp4
{
    /// <summary>
    /// Lógica interna para Consulta.xaml
    /// </summary>
    public partial class Consulta : Window
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void Pesquisar_Click(object sender, RoutedEventArgs e)
        {
            var alunos = new List<Aluno>();
            string strconn = "Server=localhost;Database=bdlp4;Uid=root;Pwd=";
            

            string query = "SELECT * FROM Alunos WHERE Nome = @Nome and Turma = @Turma;";

            var cmd = new MySqlCommand(query, new MySqlConnection(strconn));
            cmd.Parameters.AddWithValue("@Nome", txtCNome.Text);
            cmd.Parameters.AddWithValue("@Turma", txtCturma.Text);

            cmd.Connection.Open();
            MySqlDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows)
            {
                var aluno = new Aluno();
                while (rd.Read())
                {
                    aluno.ID = rd.GetInt32(0);
                    aluno.Nome = rd.GetString(1);
                    aluno.Turma = rd.GetString(2);
                    aluno.Idade = rd.GetInt32(3);

                    alunos.Add(aluno);
                }

                cmd.Connection.Close();
            }
            else MessageBox.Show("Aluno não encontrado!!");
            
            

            dtGrid.ItemsSource = alunos;
        }
    }
}
