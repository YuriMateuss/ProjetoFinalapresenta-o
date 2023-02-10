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
    public partial class VeiculoWindow : Window
    {
        public VeiculoWindow()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Veiculo v = new Veiculo();
            v.Id = int.Parse(txtId.Text);
            v.Nome = txtVeiculo.Text;
            NVeiculo.Inserir(v);

            Button_Click_1(sender, e);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            listVeiculos.ItemsSource = null;
            listVeiculos.ItemsSource = NVeiculo.Listar();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Veiculo v = new Veiculo();
            v.Id = int.Parse(txtId.Text);
            v.Nome = txtVeiculo.Text;
            NVeiculo.Atualizar(v);

            Button_Click_1(sender, e);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Veiculo v = new Veiculo();
            v.Id = int.Parse(txtId.Text);
            NVeiculo.Excluir(v);
            Button_Click_1(sender, e);
        }

        private void listVeiculos1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listVeiculos.SelectedItem != null)
            {
                Veiculo obj = (Veiculo)listVeiculos.SelectedItem;
                txtId.Text = obj.Id.ToString();
                txtVeiculo.Text = obj.Nome.ToString();
            }
        }
    }
}
