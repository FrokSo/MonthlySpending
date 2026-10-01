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

        public async Task<IReadOnlyList<TransactionDto>> GetTransactionByMonthAsync(int year, int month, CancellationToken cancellationToken = default)
        {
            var transactions = await _transactions.GetTransactionsByMonthAsync(year, month, cancellationToken);
            return transactions.Select(TransactionDto.FromEntity).ToList();
        }
    }
}
