using GerenciadorDeCondominios.BLL.Models;
using GerenciadorDeCondominios.DAL.Intefaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorDeCondominios.DAL.Repositorios
{
    public class UsuarioRepositorio : RepositorioGenerico<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(Contexto contexto) : base(contexto)
        {
        }
    }
}
