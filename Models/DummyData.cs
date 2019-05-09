using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCrud.Data;

namespace WebApiCrud.Models
{
    public class DummyData
    {
        public static void Initialize(ApplicationDbContext db)
        {
            //if (!db.Clientes.Any())
            //{
            //    db.Clientes.Add(new Cliente
            //    {
            //        Cnpj = "00000000",
            //        Endereco = "Rua da Ulbra",
            //        Email = "ulbra@ulbra.com",
            //        NomeFantasia = "Ulbra",
            //        RazaoSocial = "Universidade Luterana do Brasil",
            //        Telefone = "51 30775566"
            //    });
            //    db.SaveChanges();
            //}
        }
    }
}
