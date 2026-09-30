using Thrifty.Domain.Entities;
using Thrifty.Domain.Enums;

namespace Thrifty.Application.Transactions
{
    // Shape matches the Transaction interface in Frontend/src/types/index.ts.
    public class TransactionDto
    {
        public string Id { get; }

        public DateOnly Date { get; }

        public string Merchant { get; }

        public string? Note { get; }

        public CategoryId Category { get; }

        public string PaymentMethod { get; }

        public decimal Amount { get; }

        public TransactionDto(
            string id,
            DateOnly date,
            string merchant,
            string? note,
            CategoryId category,
            string paymentMethod,
            decimal amount)
        {
            Id = id;
            Date = date;
            Merchant = merchant;
            Note = note;
            Category = category;
            PaymentMethod = paymentMethod;
            Amount = amount;
        }

        public static TransactionDto FromEntity(Transaction transaction)
        {
            return new TransactionDto(
                transaction.Id.ToString(),
                transaction.Date,
                transaction.Merchant,
                transaction.Note,
                transaction.Category,
                transaction.PaymentMethod,
                transaction.Amount);
        }
    }
}
