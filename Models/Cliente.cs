using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCrud.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Email { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
    }
}
