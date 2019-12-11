using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoWPF.WPF.Model.Pessoa
{
    public class PessoaPesquisaModel
    {
        public string Documento { get; set; }
        public string Nome { get; set; }

        public PessoaPesquisaModel(string documento, string nome)
        {
            Documento = documento;
            Nome = nome;
        }
    }
}
