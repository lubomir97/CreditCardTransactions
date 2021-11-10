using Core.Interfaces.Repositories;
using Core.Models;
using Infrastructure.Context;
using Infrastructure.Repositories.Base;

namespace Infrastructure.Repositories
{
    public class ClientStatusTypeRepository : Repository<ClientStatusType>, IClientStatusTypeRepository
    {
        public ClientStatusTypeRepository(CardTransactionDBContext context) : base(context)
        {
        }
    }
}
