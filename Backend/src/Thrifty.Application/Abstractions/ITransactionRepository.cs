using Thrifty.Application.Transactions;
using Thrifty.Domain.Entities;

namespace Thrifty.Application.Abstractions
{
    public interface ITransactionRepository
    {
        Task<Transaction> CreateTransactionAsync(Transaction transaction, CancellationToken cancellationToken = default);
        Task<bool> DeleteTransactionAsync(int id, CancellationToken cancellationToken = default);
        Task<Transaction> UpdateTransactionAsync(Transaction transaction, CancellationToken cancellationToken = default);
        Task<IReadOnlyList<Transaction>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<IReadOnlyList<Transaction>> GetTransactionsByMonthAsync(string date, CancellationToken cancellationToken = default);
        Task<IReadOnlyList<Transaction>> GetTransactionsRangeMonthAsync(string startDate, string endDate, CancellationToken cancellationToken = default);

    }
}
