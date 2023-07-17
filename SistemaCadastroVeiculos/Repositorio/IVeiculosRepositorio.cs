using SistemaCadastroVeiculos.Models;
using System.Collections.Generic;

namespace SistemaCadastroVeiculos.Repositorio
{
    public interface IVeiculosRepositorio
    {
        List<VeiculoModel> BuscarTodos();
        VeiculoModel Adicionar(VeiculoModel veiculo);
    }
}
