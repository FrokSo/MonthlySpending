using System;
using System.Collections.Generic;
using System.Text;
using Thrifty.Domain.Entities;
using Thrifty.Domain.Enums;

namespace Thrifty.Application.Transactions
{
    public class CreateTransactionRequest
    {
        public DateOnly Date { get; set; }

        public required string Merchant { get; set; }

        public string? Note { get; set; }

        public CategoryId Category { get; set; }

        public required string PaymentMethod { get; set; }

        // Signed: negative = expense, positive = income.
        public decimal Amount { get; set; }


        public static Transaction ToEntity(CreateTransactionRequest createTransactionRequest)
        {
            return new Transaction()
            {
                Date = createTransactionRequest.Date,
                Merchant = createTransactionRequest.Merchant,
                Note = createTransactionRequest.Note,
                Category = createTransactionRequest.Category,
                PaymentMethod = createTransactionRequest.PaymentMethod,
                Amount = createTransactionRequest.Amount,
            };
        }
    }
}
