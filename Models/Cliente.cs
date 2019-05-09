using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace WebApiCrud.Models
{
    public class Cliente
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("razaoSocial")]
        [DisplayName("Razão Social")]
        public string RazaoSocial { get; set; }

        [BsonElement("nomeFantasia")]
        [DisplayName("Nome Fantasia")]
        public string NomeFantasia { get; set; }

        [BsonElement("email")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [BsonElement("cnpj")]
        [DisplayName("CNPJ")]
        public string Cnpj { get; set; }

        [BsonElement("telefone")]
        [DisplayName("Telefone")]
        public string Telefone { get; set; }

        [BsonElement("endereco")]
        [DisplayName("Endereço")]
        public string Endereco { get; set; }
    }
}
