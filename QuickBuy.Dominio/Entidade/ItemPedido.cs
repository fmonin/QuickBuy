using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidade
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        
        public override void Validade()
        {
            if (ProdutoId == 0)
                AdicionaCritica("Não foi possivel identificar a referencia");
            if (Quantidade == 0)
                AdicionaCritica("Quandidade não informada");        }
    }
}
