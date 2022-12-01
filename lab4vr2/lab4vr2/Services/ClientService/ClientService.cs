namespace lab4vr2.Services.ClientService
{
    public class ClientService : IClientService
    {
        private readonly DataContext _context;

        public ClientService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Client>> AddClient(Client hero)
        {
            _context.Clients.Add(hero);
            await _context.SaveChangesAsync();
            return await _context.Clients.ToListAsync();
        }

        public async Task<List<Client>?> DeleteClient(int id)
        {
            var hero = await _context.Clients.FindAsync(id);
            if (hero is null)
                return null;

            _context.Clients.Remove(hero);
            await _context.SaveChangesAsync();

            return await _context.Clients.ToListAsync();
        }

        public async Task<List<Client>> GetAllClients()
        {
            var heroes = await _context.Clients.ToListAsync();
            return heroes;
        }

        public async Task<Client?> GetSingleClient(int id)
        {
            var hero = await _context.Clients.FindAsync(id);
            if (hero is null)
                return null;

            return hero;
        }

        public async Task<List<Client>?> UpdateClient(int id, Client request)
        {
            var hero = await _context.Clients.FindAsync(id);
            if (hero is null)
                return null;

            hero.Full_name = request.Full_name;
            hero.Address = request.Address;
            hero.Email = request.Email;
            hero.Telephone = request.Telephone;

            await _context.SaveChangesAsync();

            return await _context.Clients.ToListAsync();
        }
    }
}
