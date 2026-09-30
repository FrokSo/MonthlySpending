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

        /// <summary>
        /// Retrieves all transactions based on a month 
        /// </summary>
        /// <param name="monthYear">the date in months & year, e.g. 2026-09</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<IReadOnlyList<Transaction>> GetTransactionsByMonthAsync(string monthYear, CancellationToken cancellationToken = default)
        {
            return await _db.Transactions
                .AsNoTracking()
                .Where(t => t.Date.ToString().StartsWith(monthYear))
                .OrderByDescending(t => t.Date)
                .ToListAsync(cancellationToken);
        }


    }
}
