using Microsoft.EntityFrameworkCore;
using Thrifty.Application.Abstractions;
using Thrifty.Domain.Entities;
using Thrifty.Infrastructure.Persistence;

namespace Thrifty.Infrastructure.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly AppDbContext _db;

        public TransactionRepository(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IReadOnlyList<Transaction>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await _db.Transactions
                .AsNoTracking()
                .OrderByDescending(t => t.Date)
                .ThenByDescending(t => t.Id)
                .ToListAsync(cancellationToken);
        }
    }
}
