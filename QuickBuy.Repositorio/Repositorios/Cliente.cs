﻿using QuickBuy.Dominio.Entidade;

namespace QuickBuy.Repositorio.Repositorios
{
    public class Cliente
    {
        public Cliente()
        {
            var usuarioRepositorio = new UsuarioRepositorio();
            var usuario = new Usuario();

            usuarioRepositorio.Adicionar(usuario);

        }

    }
}
