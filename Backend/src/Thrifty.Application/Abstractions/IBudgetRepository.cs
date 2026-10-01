using System;
using System.Collections.Generic;
using System.Text;
using Thrifty.Domain.Entities;


namespace Thrifty.Application.Abstractions
{
    public interface IBudgetRepository
    {
        Task<Budget> CreateBudgetAsync(Budget budget);
        Task<Budget> DeleteBudgetAsync(Budget budget);
        Task<Budget> UpdateBudgetAsync(Budget budget);
        Task<IReadOnlyList<Budget>> GetByMonthAsync(int year, int month, CancellationToken cancellationToken = default);

    }
}
