import IconIndicator from '../ui/IconIndicator';
import Badge from '../ui/Badge';
import { categories } from '../../data/categories';
import type { Transaction } from '../../types';
import styles from './TransactionRow.module.css';

interface TransactionRowProps {
  transaction: Transaction;
  showCategoryBadge?: boolean;
}

export default function TransactionRow({ transaction, showCategoryBadge = false }: TransactionRowProps) {
  const cat = categories[transaction.category];
  const isIncome = transaction.amount > 0;

  return (
    <div className={styles.row}>
      <IconIndicator icon={cat.icon} colorVar={cat.colorVar} />
      <div className={styles.info}>
        <div className={styles.merchant}>{transaction.merchant}</div>
        <div className={styles.meta}>
          {!showCategoryBadge && <span>{cat.label}</span>}
          {transaction.note && <span> · {transaction.note}</span>}
        </div>
      </div>
      {showCategoryBadge && (
        <Badge tone="category" colorVar={cat.colorVar}>
          {cat.label}
        </Badge>
      )}
      <span className={styles.paymentMethod}>{transaction.paymentMethod}</span>
      <span className={isIncome ? styles.amountPositive : styles.amountNegative}>
        {isIncome ? '+' : '-'}S${Math.abs(transaction.amount).toFixed(2)}
      </span>
    </div>
  );
}
