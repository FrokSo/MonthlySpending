using Thrifty.Domain.Enums;

namespace Thrifty.Domain.Entities;

public class Transaction
{
    public int Id { get; set; }

    public DateOnly Date { get; set; }

    public required string Merchant { get; set; }

    public string? Note { get; set; }

    public CategoryId Category { get; set; }

    public required string PaymentMethod { get; set; }

    // Signed: negative = expense, positive = income.
    public decimal Amount { get; set; }
}
