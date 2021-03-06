﻿using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidade
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagameto { get; set; }  

        // Pedido deve ter pelo menos um Item de Pedido ou muitos Itens de Pedido
        public  ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validade()
        {
            LimparMensagensValidacao();

            if (!ItensPedido.Any())
                AdicionaCritica("Critica - Pedido não pode ficar sem Item de Pedido");

            if (string.IsNullOrEmpty(CEP))
                AdicionaCritica("Critica - CEP deve estar preenchido");                    

         
        }
    }
}
