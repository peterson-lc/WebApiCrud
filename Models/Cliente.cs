using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCrud.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [DisplayName("Razão Social")]
        public string RazaoSocial { get; set; }

        [DisplayName("Nome Fantasia")]
        public string NomeFantasia { get; set; }

        [DisplayName("E-mail")]
        public string Email { get; set; }

        [DisplayName("CNPJ")]
        public string Cnpj { get; set; }

        [DisplayName("Telefone")]
        public string Telefone { get; set; }

        [DisplayName("Endereço")]
        public string Endereco { get; set; }
    }
}
