using System;

namespace SistemaCadastroVeiculos.Models
{
    public class VeiculoModel
    {
        public int Id { get; set; }
        public Boolean Mercosul {get; set; }    
        public string Placa { get; set; } 
        public string Renavam { get; set; } 
        public string Nome { get; set; }
        public string CPF  { get; set; } 
        public Boolean Bloqueio { get; set; }

    }
}
