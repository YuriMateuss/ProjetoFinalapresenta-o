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

namespace ProejtoFinalPEOOFabricantedeVeiculos
{
    /// <summary>
    /// Lógica interna para Registrados1Window.xaml
    /// </summary>
    public partial class Registrados1Window : Window
    {
        public Registrados1Window()
        {
            InitializeComponent();
            listVeiculos.ItemsSource = NVeiculo.Listar();
        }

        private void ListaraqClick(object sender, RoutedEventArgs e)
        {
            if (listVeiculos.SelectedItem != null)
            {
                Veiculo v = (Veiculo)listVeiculos.SelectedItem;
                listModelos.ItemsSource = null;
                listModelos.ItemsSource = NModelo.Listar(v);
            }
            else
                MessageBox.Show("É preciso selecionar um veículo!!!");
        }
        private void listVeiculos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void listModelos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
