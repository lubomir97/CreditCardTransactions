using Core.Interfaces.Repositories;
using Core.Models;
using Infrastructure.Context;
using Infrastructure.Repositories.Base;

namespace Infrastructure.Repositories
{
    public class CardAccountTransactionRepository : Repository<CardAccountTransaction>, ICardAccountTransactionRepository
    {
        public CardAccountTransactionRepository(CardTransactionDBContext context) : base(context)
        {
        }
    }
}
