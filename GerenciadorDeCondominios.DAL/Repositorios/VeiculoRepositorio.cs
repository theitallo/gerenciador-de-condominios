﻿using GerenciadorDeCondominios.BLL.Models;
using GerenciadorDeCondominios.DAL.Intefaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeCondominios.DAL.Repositorios
{
    public class VeiculoRepositorio : RepositorioGenerico<Veiculo>, IVeiculoRepositorio
    {
        private readonly Contexto _contexto;

        public VeiculoRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public async Task<IEnumerable<Veiculo>> PegarVeiculosPorUsuario(string usuarioId)
        {
            try
            {
                return await _contexto.Veiculos.Where(v => v.UsuarioId == usuarioId).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
