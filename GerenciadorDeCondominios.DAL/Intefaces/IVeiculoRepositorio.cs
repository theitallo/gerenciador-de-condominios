using GerenciadorDeCondominios.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeCondominios.DAL.Intefaces
{
    public interface IVeiculoRepositorio : IRepositorioGenerico<Veiculo>
    {
        Task<IEnumerable<Veiculo>> PegarVeiculosPorUsuario(string usuarioId); 
    }
}
