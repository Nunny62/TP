using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using lab4vr2.Repository;
using lab4vr2.Services.ClientService;

namespace lab4vr2.Controllers
{
    [ApiController]
    [Route("/client")]
    public class ClientController : ControllerBase
    {

       private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Client>>> GetAllClient()
        {
            return await _clientService.GetAllClients();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Client>> GetSingleClient(int id)
        {
            var result = await _clientService.GetSingleClient(id);
            if (result is null)
                return NotFound("Client not found.");

            return Ok(result);
        }

        /*[HttpPut]
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
       }*/
    }
}