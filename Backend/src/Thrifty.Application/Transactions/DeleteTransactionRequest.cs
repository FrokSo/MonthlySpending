using System;
using System.Collections.Generic;
using System.Text;
using Thrifty.Domain.Entities;

namespace Thrifty.Application.Transactions
{
    public class DeleteTransactionRequest
    {
        public int Id { get; set; }

        public static Transaction ToEntity(DeleteTransactionRequest deleteTransactionRequest)
        {
            return new Transaction() { Id = deleteTransactionRequest.Id, Merchant = "", PaymentMethod = "" };
        }
    }

}
