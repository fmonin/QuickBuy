using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidade
{
    public abstract class Entidade
    {
        public List<string> _mensagemValidacao { get; set; }
        private List<string> mensagemValidacao
        {
            get { return _mensagemValidacao ?? (_mensagemValidacao = new List<string>()); }
        }

        protected void LimparMensagensValidacao()
        {
            mensagemValidacao.Clear();
        }

        protected void AdicionaCritica(string mensagem)
        {
            mensagemValidacao.Add(mensagem);
        }
        public abstract void Validade();
        protected bool EhValido
        {
            get { return !mensagemValidacao.Any(); }    
        }
    }
}
