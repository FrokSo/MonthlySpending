using Thrifty.Domain.Entities;

namespace Thrifty.Application.Abstractions
{
    public interface ITransactionRepository
    {
        Task<Transaction> CreateTransactionAsync(Transaction transaction);
        Task<Transaction> DeleteTransactionAsync(Transaction transaction);
        Task<Transaction> UpdateTransactionAsync(Transaction transaction);
        Task<IReadOnlyList<Transaction>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<IReadOnlyList<Transaction>> GetTransactionsByMonthAsync(int year, int month, CancellationToken cancellationToken = default);
        Task<IReadOnlyList<Transaction>> GetTransactionsRangeMonthAsync(int startYear, int startMonth, int endYear, int endMonth, CancellationToken cancellationToken = default);

    }
}
