using Thrifty.Domain.Entities;

namespace Thrifty.Application.Abstractions
{
    public interface ITransactionRepository
    {
        Task<Transaction> CreateTransactionAsync(Transaction transaction);
        Task<Transaction> DeleteTransactionAsync(Transaction transaction);
        Task<Transaction> UpdateTransactionAsync(Transaction transaction);
        Task<IReadOnlyList<Transaction>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<IReadOnlyList<Transaction>> GetTransactionsByMonthAsync(string date, CancellationToken cancellationToken = default);
        Task<IReadOnlyList<Transaction>> GetTransactionsRangeMonthAsync(string startDate, string endDate, CancellationToken cancellationToken = default);

    }
}
