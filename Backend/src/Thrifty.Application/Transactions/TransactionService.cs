using Thrifty.Application.Abstractions;

namespace Thrifty.Application.Transactions
{
    public class TransactionService
    {
        private readonly ITransactionRepository _transactions;

        public TransactionService(ITransactionRepository transactions)
        {
            _transactions = transactions;
        }

        public async Task<IReadOnlyList<TransactionDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var entities = await _transactions.GetAllAsync(cancellationToken);
            return entities.Select(TransactionDto.FromEntity).ToList();
        }

        public async Task<IReadOnlyList<TransactionDto>> GetTransactionByMonthAsync(string date, CancellationToken cancellationToken = default)
        {
            var transactions = await _transactions.GetTransactionsByMonthAsync(date, cancellationToken);
            return transactions.Select(TransactionDto.FromEntity).ToList();
        }

        public async Task<IReadOnlyList<TransactionDto>> GetTransactionsRangeMonthAsync(string startDate, string endDate, CancellationToken cancellationToken = default)
        {
            var transactions = await _transactions.GetTransactionsRangeMonthAsync(startDate, endDate, cancellationToken);
            return transactions.Select(TransactionDto.FromEntity).ToList();
        }

    }
}
