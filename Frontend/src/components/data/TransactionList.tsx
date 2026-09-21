import TransactionRow from './TransactionRow';
import type { Transaction } from '../../types';
import styles from './TransactionList.module.css';

interface TransactionListProps {
  transactions: Transaction[];
  showCategoryBadge?: boolean;
  groupByDate?: boolean;
}

function formatDateLabel(date: string): string {
  const d = new Date(date);
  const today = new Date('2026-09-18');
  const isToday = d.toDateString() === today.toDateString();
  if (isToday) return 'Today, ' + d.toLocaleDateString('en-SG', { day: 'numeric', month: 'short' });
  return d.toLocaleDateString('en-SG', { day: 'numeric', month: 'short' });
}

export default function TransactionList({
  transactions,
  showCategoryBadge = false,
  groupByDate = false,
}: TransactionListProps) {
  if (!groupByDate) {
    return (
      <div>
        {transactions.map((t) => (
          <TransactionRow key={t.id} transaction={t} showCategoryBadge={showCategoryBadge} />
        ))}
      </div>
    );
  }

  const groups = new Map<string, Transaction[]>();
  for (const t of transactions) {
    const key = t.date;
    if (!groups.has(key)) groups.set(key, []);
    groups.get(key)!.push(t);
  }

  return (
    <div>
      {Array.from(groups.entries()).map(([date, items]) => (
        <div key={date} className={styles.group}>
          <div className={styles.dateHeader}>{formatDateLabel(date)}</div>
          {items.map((t) => (
            <TransactionRow key={t.id} transaction={t} showCategoryBadge={showCategoryBadge} />
          ))}
        </div>
      ))}
    </div>
  );
}
