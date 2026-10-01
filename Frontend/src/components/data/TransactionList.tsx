import TransactionRow from './TransactionRow';
import type { Transaction } from '../../types';
import { toIsoDate } from '../../utils/date';
import styles from './TransactionList.module.css';

interface TransactionListProps {
  transactions: Transaction[];
  showCategoryBadge?: boolean;
  groupByDate?: boolean;
}

function formatDateLabel(date: string): string {
  // Appending a time makes the Date parse as local midnight; a bare "YYYY-MM-DD" parses as UTC.
  const label = new Date(`${date}T00:00:00`).toLocaleDateString('en-SG', { day: 'numeric', month: 'short' });
  return date === toIsoDate(new Date()) ? 'Today, ' + label : label;
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
