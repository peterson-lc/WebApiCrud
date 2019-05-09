using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using WebApiCrud.Models;

namespace WebApiCrud.Services
{
    public class ClienteService
    {
        private readonly IMongoCollection<Cliente> _clientes;

        public ClienteService(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("ClientesDb"));
            var database = client.GetDatabase("ClientesDb");
            _clientes = database.GetCollection<Cliente>("Clientes");
        }

        public List<Cliente> Get()
        {
            return _clientes.Find(x => true).ToList();
        }

        public Cliente Get(string id)
        {
            return _clientes.Find<Cliente>(x => x.Id == id).FirstOrDefault();
        }

        public Cliente Create(Cliente cliente)
        {
            _clientes.InsertOne(cliente);
            return cliente;
        }

        public void Update(string id, Cliente cliente)
        {
            _clientes.ReplaceOne(x => x.Id == id, cliente);
        }

        public void Remove(Cliente cliente)
        {
            _clientes.DeleteOne(x => x.Id == cliente.Id);
        }

        public void Remove(string id)
        {
            _clientes.DeleteOne(x => x.Id == id);
        }

    }
}
