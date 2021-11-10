using Core.Interfaces.Repositories;
using Core.Models;
using Infrastructure.Context;
using Infrastructure.Repositories.Base;

namespace Infrastructure.Repositories
{
    public class CardAccountTransactionTypeRepository : Repository<CardAccountTransactionType>, 
        ICardAccountTransactionTypeRepository
    {
        public CardAccountTransactionTypeRepository(CardTransactionDBContext context) : base(context)
        {

        }
    }
}
