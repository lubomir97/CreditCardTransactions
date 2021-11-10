using Core.Interfaces.Repositories;
using Core.Models;
using Infrastructure.Context;
using Infrastructure.Repositories.Base;

namespace Infrastructure.Repositories
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        public ClientRepository(CardTransactionDBContext context) : base(context)
        {

        }
    }
}
