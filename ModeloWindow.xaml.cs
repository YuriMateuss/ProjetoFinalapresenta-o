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
    /// Lógica interna para ModeloWindow.xaml
    /// </summary>
    public partial class ModeloWindow : Window
    {
        public ModeloWindow()
        {
            InitializeComponent();
        }
        private void InserirClick(object sender, RoutedEventArgs e)
        {
            Modelo a = new Modelo();
            a.Id = int.Parse(txtid.Text);
            a.ModeloC = txtmodelos.Text;
            a.Preco = int.Parse(txtpreco.Text);
            NModelo.Inserir(a);

            ListarClick(sender, e);
        }
        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listModelos.ItemsSource = null;
            listModelos.ItemsSource = NModelo.Listar();
        }

        private void AtualizarClick(object sender, RoutedEventArgs e)
        {

            Modelo a = new Modelo();
            a.Id = int.Parse(txtid.Text);
            a.ModeloC = txtmodelos.Text;
            a.preco = txtpreco.Text;
            NModelo.Atualizar(a);

            ListarClick(sender, e);
        }

        private void ExcluirClick(object sender, RoutedEventArgs e)
        {

            Modelo a = new Modelo();
            a.Id = int.Parse(txtid.Text);
            NModelo.Excluir(a);
            ListarClick(sender, e);
        }

        private void listModelos1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listModelos.SelectedItem != null)
            {
                Modelo obj = (Modelo)listModelos.SelectedItem;
                txtid.Text = obj.Id.ToString();
                txtmodelos.Text = obj.ModeloC.ToString();
                txtpreco.Text = obj.Preco.ToString();
            }
        }
    }
}