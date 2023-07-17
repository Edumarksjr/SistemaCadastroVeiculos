using SistemaCadastroVeiculos.Data;
using SistemaCadastroVeiculos.Models;
using System.Collections.Generic;
using System.Linq;

namespace SistemaCadastroVeiculos.Repositorio
{
    public class VeiculoRepositorio : IVeiculosRepositorio
    {
        private readonly BancoContext _bancoContext;
        public VeiculoRepositorio(BancoContext bancoContext)
        { 
            _bancoContext = bancoContext;   
        }
        public List<VeiculoModel> BuscarTodos()
        {
            return _bancoContext.Veiculos.ToList();
        }

        public VeiculoModel Adicionar(VeiculoModel veiculo)
        {
            _bancoContext.Veiculos.Add(veiculo);
            _bancoContext.SaveChanges();  
            return veiculo;

        }

       
    }
}
