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
    /// Lógica interna para RegistradosWindow.xaml
    /// </summary>
    public partial class RegistradosWindow : Window
    { 
        public RegistradosWindow()
        {
            InitializeComponent();
            listFabricantes.ItemsSource = NFabricante.Listar();
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            if (listFabricantes.SelectedItem != null)
            {
                Fabricante t = (Fabricante)listFabricantes.SelectedItem;
                listVeiculos.ItemsSource = null;
                listVeiculos.ItemsSource = NVeiculo.Listar(t);
            }
            else
                MessageBox.Show("É preciso selecionar um veículo!!!");
        }
        private void listfabricantes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
      }
    }
