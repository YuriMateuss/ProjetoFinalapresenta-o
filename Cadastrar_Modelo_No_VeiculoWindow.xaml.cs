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
    /// Lógica interna para Cadastrar_Modelo_No_VeiculoWindow.xaml
    /// </summary>
    public partial class Cadastrar_Modelo_No_VeiculoWindow : Window
    {
        public Cadastrar_Modelo_No_VeiculoWindow()
        {
            InitializeComponent();
        }
        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listVeiculos.ItemsSource = null;
            listVeiculos.ItemsSource = NVeiculo.Listar();
            listModelos.ItemsSource = null;
            listModelos.ItemsSource = NModelo.Listar();
        }
        private void CadastroClick(object sender, RoutedEventArgs e)
        {
            if (listVeiculos.SelectedItem != null && listModelos.SelectedItem != null)
            {
                Modelo m = (Modelo)listModelos.SelectedItem;
                Veiculo v = (Veiculo)listVeiculos.SelectedItem;
                NModelo.Cadastrar(m, v);
                ListarClick(sender, e);
            }
            else
            {
                MessageBox.Show("É preciso selecionar um modelo e um fabricante");
            }
        }
    }
}
