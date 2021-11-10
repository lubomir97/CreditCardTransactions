using Core.Interfaces.Repositories;
using Core.Models;
using Infrastructure.Context;
using Infrastructure.Repositories.Base;

namespace Infrastructure.Repositories
{
    public class CardAccountRepository : Repository<CardAccount>, ICardAccountRepository
    {
        public CardAccountRepository(CardTransactionDBContext context) : base(context)
        {
        }
    }
}
