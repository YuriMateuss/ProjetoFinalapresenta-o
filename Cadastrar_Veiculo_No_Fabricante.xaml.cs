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
    /// Lógica interna para Cadastrar_Veiculo_No_Fabricante.xaml
    /// </summary>
    public partial class Cadastrar_Veiculo_No_Fabricante : Window
    {
        public Cadastrar_Veiculo_No_Fabricante()
        {
            InitializeComponent();

        }
        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listFabricantes.ItemsSource = null;
            listFabricantes.ItemsSource = NFabricante.Listar();
            listVeiculos.ItemsSource = null;
            listVeiculos.ItemsSource = NVeiculo.Listar();
        }
        private void CadastroClick(object sender, RoutedEventArgs e)
        {
            if (listFabricantes.SelectedItem != null && listVeiculos.SelectedItem != null)
            {
                Veiculo v = (Veiculo)listVeiculos.SelectedItem;
                Fabricante t = (Fabricante)listFabricantes.SelectedItem;
                NVeiculo.Cadastrar(v, t);
                ListarClick(sender, e);
            }
            else
            {
                MessageBox.Show("É preciso selecionar um Veiculo e um Fabricante");
            }
        }

        private void listVeiculo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}