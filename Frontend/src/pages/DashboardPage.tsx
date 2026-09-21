import { useState } from 'react';
import Card from '../components/ui/Card';
import Dropdown from '../components/ui/Dropdown';
import StatCard from '../components/data/StatCard';
import DonutChart from '../components/data/DonutChart';
import BarChart from '../components/data/BarChart';
import BudgetCategoryCard from '../components/data/BudgetCategoryCard';
import TransactionList from '../components/data/TransactionList';
import { budgets, dailySpend, summary, transactions } from '../data/mockData';
import styles from './DashboardPage.module.css';

export default function DashboardPage() {
  const [, setMonthOffset] = useState(0);
  const peakIndex = dailySpend.reduce(
    (best, cur, i, arr) => (cur.amount > arr[best].amount ? i : best),
    0
  );
  const recentTransactions = transactions.filter((t) => t.amount < 0).slice(0, 4);
  const featuredBudgets = budgets.filter((b) => b.status !== 'unused');

  return (
    <div className={styles.page}>
      <div className={styles.header}>
        <div>
          <h1 className={styles.title}>{summary.currentMonth}</h1>
          <p className={styles.subtitle}>{summary.daysLeftInMonth} days left in the month</p>
        </div>
        <Dropdown
          label="This month"
          onPrev={() => setMonthOffset((m) => m - 1)}
          onNext={() => setMonthOffset((m) => m + 1)}
        />
      </div>

      <div className={styles.statsRow}>
        <StatCard label="Income" value={`S$${summary.income.toLocaleString()}`} sublabel="Salary, 1 Sep" />
        <StatCard
          label="Spent so far"
          value={`S$${summary.spent.toLocaleString()}`}
          sublabel={`↘ ${Math.abs(summary.vsLastMonthPercent)}% less than August`}
        />
        <StatCard
          label="Left to spend"
          value={`S$${(summary.budget - summary.spent).toLocaleString()}`}
          sublabel={`of S$${summary.budget.toLocaleString()} budget`}
          emphasis
        />
      </div>

      <div className={styles.grid2}>
        <Card>
          <h2 className={styles.cardTitle}>Spending by category</h2>
          <DonutChart
            data={budgets.filter((b) => b.spent > 0).map((b) => ({ category: b.category, amount: b.spent }))}
            centerValue={`S$${summary.spent.toLocaleString()}`}
            centerLabel="spent"
          />
        </Card>
        <Card>
          <div className={styles.cardHeaderRow}>
            <h2 className={styles.cardTitle}>Daily spending</h2>
            <span className={styles.avgLabel}>Avg S$121 a day</span>
          </div>
          <BarChart
            data={dailySpend.map((d) => ({ label: d.date, value: d.amount }))}
            highlightIndex={peakIndex}
          />
        </Card>
      </div>

      <div className={styles.grid2}>
        <Card>
          <h2 className={styles.cardTitle}>Budgets</h2>
          <div className={styles.budgetList}>
            {featuredBudgets.map((b) => (
              <BudgetCategoryCard key={b.category} budget={b} />
            ))}
          </div>
        </Card>
        <Card>
          <div className={styles.cardHeaderRow}>
            <h2 className={styles.cardTitle}>Recent transactions</h2>
            <a className={styles.viewAll} href="/transactions">
              View all
            </a>
          </div>
          <TransactionList transactions={recentTransactions} />
        </Card>
      </div>
    </div>
  );
}
