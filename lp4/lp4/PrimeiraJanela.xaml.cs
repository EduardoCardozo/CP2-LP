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

namespace lp4
{
    /// <summary>
    /// Interaction logic for PrimeiraJanela.xaml
    /// </summary>
    public partial class PrimeiraJanela : Window
    {
        public PrimeiraJanela()
        {
            InitializeComponent();
        }

        private void btnJanelaCadastro_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }

        private void btnJanelaCsonsulta_Click(object sender, RoutedEventArgs e)
        {
            new Consulta().Show();
            this.Close();
        }
    }
}
