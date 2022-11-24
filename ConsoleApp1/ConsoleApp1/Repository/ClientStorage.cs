using System;
using Practice2.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Practice2.Repository
{
    public class ClientStorage
    {
        private Dictionary<int, Client> Clients { get; } = new Dictionary<int, Client>();

        public void Create(Client client)
        {
            Clients.Add(client.ClientID, client);
        }

        public Client Read(int clientID)
        {
            return Clients[clientID];
        }
        
        public Client Update(int clientID, Client newClient)
        {
            Clients[clientID] = newClient;
            return Clients[clientID];
        }

        public bool Delete(int clientID)
        {
            return Clients.Remove(clientID);
        }
    }
}
