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

        public Task<Transaction> CreateTransactionAsync(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public Task<Transaction> DeleteTransactionAsync(Transaction transaction)
        {
            throw new NotImplementedException();
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
        public async Task<IReadOnlyList<Transaction>> GetTransactionsByMonthAsync(int year, int month, CancellationToken cancellationToken = default)
        {
            string monthYear = year.ToString() + "-" + month.ToString("D2");
            return await _db.Transactions
                .AsNoTracking()
                .Where(t => t.Date.ToString().StartsWith(monthYear))
                .OrderByDescending(t => t.Date)
                .ToListAsync(cancellationToken);
        }

        public Task<IReadOnlyList<Transaction>> GetTransactionsRangeMonthAsync(int startYear, int startMonth, int endYear, int endMonth, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<Transaction> UpdateTransactionAsync(Transaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
