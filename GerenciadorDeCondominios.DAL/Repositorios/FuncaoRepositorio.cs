using GerenciadorDeCondominios.BLL.Models;
using GerenciadorDeCondominios.DAL.Intefaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorDeCondominios.DAL.Repositorios
{
    public class FuncaoRepositorio : RepositorioGenerico<Funcao>, IFuncaoRepositorio
    {
        public FuncaoRepositorio(Contexto contexto) : base(contexto)
        {

        }
    }
}
