using ProjetoWPF.WPF.Model.Pessoa;
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

namespace ProjetoWPF.WPF.Views.Pessoa
{
    /// <summary>
    /// Lógica interna para CadastroPessoa.xaml
    /// </summary>
    public partial class CadastroPessoa : Window
    {
        public PessoaCadastroModel Pessoa { get; set; } = new PessoaCadastroModel();

        private CadastroPessoa()
        {
            InitializeComponent();
        }

        public static PessoaCadastroModel Cadastrar()
        {
            var tela = new CadastroPessoa();

            if (tela.ShowDialog() == false)
                return tela?.Pessoa ?? new PessoaCadastroModel();

            return new PessoaCadastroModel();
        }
    }
}