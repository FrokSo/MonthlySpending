using Microsoft.EntityFrameworkCore;
using Thrifty.Application.Abstractions;
using Thrifty.Domain.Entities;
using Thrifty.Infrastructure.Persistence;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        public async Task<IReadOnlyList<Transaction>> GetTransactionsByMonthAsync(string date, CancellationToken cancellationToken = default)
        {
            DateOnly month = DateOnly.Parse(date);
            var from = new DateOnly(month.Year, month.Month, 1);   
            var to = from.AddMonths(1);
            return await _db.Transactions
                .AsNoTracking()
                .Where(t => t.Date >= from && t.Date < to)
                .OrderByDescending(t => t.Date)
                .ToListAsync(cancellationToken);
        }

        public async Task<IReadOnlyList<Transaction>> GetTransactionsRangeMonthAsync(string startDate, string endDate, CancellationToken cancellationToken = default)
        {
            DateOnly start = DateOnly.Parse(startDate);
            DateOnly end = DateOnly.Parse(endDate);
            return await _db.Transactions
                .AsNoTracking()
                .Where(t => t.Date >= start && t.Date < end)
                .OrderByDescending(t => t.Date)
                .ToListAsync(cancellationToken);

        }

        public Task<Transaction> UpdateTransactionAsync(Transaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
