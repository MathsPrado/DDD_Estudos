using System;

namespace ProjetoModeloDDD.Domai.Entities
{
    public class Cliente
    {

        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public bool Atiivo { get; set; }
        public DateTime  DataCadastro { get; set; }

        public bool ClienteEspecial(Cliente cliente)
        {
            return cliente.Atiivo && DateTime.Now.Year - cliente.DataCadastro.Year >= 5;
        }
    }
}
