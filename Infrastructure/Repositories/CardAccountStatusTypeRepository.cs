using Core.Interfaces.Repositories;
using Core.Models;
using Infrastructure.Context;
using Infrastructure.Repositories.Base;
namespace Infrastructure.Repositories
{
    public class CardAccountStatusTypeRepository : Repository<CardAccountStatusType>, ICardAccountStatusTypeRepository
    {
        public CardAccountStatusTypeRepository(CardTransactionDBContext context) : base(context)
        {

        }
    }
}
