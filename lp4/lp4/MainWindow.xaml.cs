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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Common;

namespace lp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btnCadastro_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(txtIdade.Text) || String.IsNullOrEmpty(txtTurma.Text))
            {
                MessageBox.Show("Ainda tem Dados Pendentes!!!");                 
            }

            else
            {
                string strconn = "Server=localhost;Database=bdlp4;Uid=root;Pwd=";
                string query = "INSERT INTO Alunos (Nome, Idade, Turma) VALUES ('@nome', '@idade', '@turma')";
                MySqlCommand cmd = new MySqlCommand(query, new MySqlConnection(strconn));
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@idade", txtIdade.Text);
                cmd.Parameters.AddWithValue("@turma", txtTurma.Text);
                try
                {
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Aluno cadastrado com sucesso!!!");
                }
                catch (Exception) { MessageBox.Show("Aluno não foi cadastrado!!!"); }
                finally { cmd.Connection.Close(); LimparCampos();  new PrimeiraJanela().Show(); this.Close(); };

            }
            
        }
        public void LimparCampos()
        {
            txtTurma.Text = null;
            txtNome.Text = null;
            txtIdade.Text = null;

        }
    }
}
