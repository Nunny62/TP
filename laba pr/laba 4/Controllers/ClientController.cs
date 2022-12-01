using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using laba_4.Domains;
using laba_4.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace laba_4.Controllers
{
    [ApiController]
    [Route("/client")]
    public class ClientController : ControllerBase
    {
        [HttpPut]
        public Client Create(Client client)
        {
            Storage.ClientStorage.Create(client);
            return client;
        }

        [HttpGet]
        public Client Read(int clientId)
        {
            return Storage.ClientStorage.Read(clientId);
        }

        [HttpPost]
        public Client Update(int clientId, Client newClient)
        {
            return Storage.ClientStorage.Update(clientId, newClient);
        }

        [HttpDelete]
        public bool Delete(int clientId)
        {
            return Storage.ClientStorage.Delete(clientId); ;
        }
    }
}