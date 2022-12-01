namespace lab4vr2.Services.ClientService
{
    public interface IClientService
    {
        Task<List<Client>> GetAllClients();
        Task<Client?> GetSingleClient(int id);
        Task<List<Client>> AddClient(Client hero);
        Task<List<Client>?> UpdateClient(int id, Client request);
        Task<List<Client>?> DeleteClient(int id);
    }
}
