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

namespace ProejtoFinalPEOOFabricantedeVeiculos
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Veiculo_Click(object sender, RoutedEventArgs e)
        {
            VeiculoWindow w = new VeiculoWindow();
            w.ShowDialog();
        }

        private void Modelo_Click(object sender, RoutedEventArgs e)
        {
            ModeloWindow w = new ModeloWindow();
            w.ShowDialog();
        }

        private void Fabricante_Click(object sender, RoutedEventArgs e)
        {
            FabricanteWindow w = new FabricanteWindow();
            w.ShowDialog();
        }

        private void CadastrodeModelo_Click(object sender, RoutedEventArgs e)
        {
            Cadastrar_Veiculo_No_Fabricante w = new Cadastrar_Veiculo_No_Fabricante();
            w.ShowDialog();
        }
        private void CadastroVeiculo_Click(object sender, RoutedEventArgs e)
        {
            Cadastrar_Modelo_No_VeiculoWindow w = new Cadastrar_Modelo_No_VeiculoWindow();
            w.ShowDialog();
        }

        private void Registrados_Click(object sender, RoutedEventArgs e)
        {
            RegistradosWindow w = new RegistradosWindow();
            w.ShowDialog();
        }
        private void Registrados1_Click(object sender, RoutedEventArgs e)
        {
            Registrados1Window w = new Registrados1Window();
            w.ShowDialog();
        }
    }
}