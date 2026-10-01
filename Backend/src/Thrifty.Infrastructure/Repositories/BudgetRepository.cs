using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Thrifty.Application.Abstractions;
using Thrifty.Domain.Entities;
using Thrifty.Infrastructure.Persistence;

namespace Thrifty.Infrastructure.Repositories
{
    public class BudgetRepository : IBudgetRepository
    {
        private readonly AppDbContext _db;

        public BudgetRepository(AppDbContext db)
        {
            _db = db;
        }

        public Task<Budget> CreateBudgetAsync(Budget budget)
        {
            throw new NotImplementedException();
        }

        public Task<Budget> DeleteBudgetAsync(Budget budget)
        {
            throw new NotImplementedException();
        }

        public Task<Budget> UpdateBudgetAsync(Budget budget)
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyList<Budget>> GetByMonthAsync(int year, int month,CancellationToken cancellationToken = default)
        {
            return await _db.Budgets
                .AsNoTracking()
                .Where(b => b.Year == year && b.Month == month)
                .ToListAsync(cancellationToken);
        }

    }

}