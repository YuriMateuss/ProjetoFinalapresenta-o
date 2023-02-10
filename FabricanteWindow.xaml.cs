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
    /// Lógica interna para FabricanteWindow.xaml
    /// </summary>
    public partial class FabricanteWindow : Window
    {
        public FabricanteWindow()
        {

            InitializeComponent();
        }

        private void ListBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (listFabricantesn.SelectedItem != null)
            {
                Fabricante obj = (Fabricante)listFabricantesn.SelectedItem;
                txtidFabricante.Text = obj.Id.ToString();
                txtfabricante1.Text = obj.Nome;
            }

        }


        private void Listarab_Click(object sender, RoutedEventArgs e)
        {
            listFabricantesn.ItemsSource = null;
            listFabricantesn.ItemsSource = NFabricante.Listar();

        }

        private void Atualizarab_Click(object sender, RoutedEventArgs e)
        {
            Fabricante t = new Fabricante();
            t.Id = int.Parse(txtidFabricante.Text);
            t.Nome = txtfabricante1.Text;

            NFabricante.Atualizar(t);
            Listarab_Click(sender, e);

        }

        private void Excluir_Click(object sender, RoutedEventArgs e)
        {
            Fabricante t = new Fabricante();
            t.Id = int.Parse(txtidFabricante.Text);
            NFabricante.Excluir(t);
            Listarab_Click(sender, e);

        }

        private void InserirAlgo_Click(object sender, RoutedEventArgs e)
        {
            Fabricante t = new Fabricante();
            t.Id = int.Parse(txtidFabricante.Text);
            t.Nome = txtfabricante1.Text;
            NFabricante.Inserir(t);
            Listarab_Click(sender, e);
        }

        private void Inserimento_Click(object sender, RoutedEventArgs e)
        {
            Fabricante t = new Fabricante();
            t.Id = int.Parse(txtidFabricante.Text);
            t.Nome = txtfabricante1.Text;
            NFabricante.Inserir(t);
            Listarab_Click(sender, e);
        }
    }
}
