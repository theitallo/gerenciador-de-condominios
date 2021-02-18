﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeCondominios.DAL.Intefaces
{
    public interface IRepositorioGenerico<TEntity> where TEntity: class
    {
        Task<IEnumerable<TEntity>> PegarTodos();

        Task<TEntity> PegarPeloId(int id);

        Task<TEntity> PegarPeloId(string id);

        Task Inserir(TEntity entity);

        Task Atualizar(TEntity entity);
     
        Task Excluir(TEntity entity);

        Task Excluir(int id);
     
        Task Excluir(string id);
    }
}
