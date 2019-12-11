using ProjetoWPF.WPF.Model.Pessoa;
using ProjetoWPF.WPF.Views.Pessoa;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ProjetoWPF.WPF
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<PessoaPesquisaModel> Pessoas { get; set; } = new ObservableCollection<PessoaPesquisaModel>();
        private PessoaCadastroModel Pessoa { get; set; } = new PessoaCadastroModel();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void btnPesquisar_Click(object sender, RoutedEventArgs e)
        {
            Pessoas.Add(new PessoaPesquisaModel("08887953945", "JULIANO MACIEL"));
        }

        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            Pessoas.Clear();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            Pessoa = CadastroPessoa.Cadastrar();
        }
    }
}