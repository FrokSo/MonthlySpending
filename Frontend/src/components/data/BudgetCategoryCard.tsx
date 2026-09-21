import Card from '../ui/Card';
import Badge from '../ui/Badge';
import ProgressBar from '../ui/ProgressBar';
import IconIndicator from '../ui/IconIndicator';
import { categories } from '../../data/mockData';
import type { BudgetCategory } from '../../types';
import styles from './BudgetCategoryCard.module.css';

const statusConfig: Record<BudgetCategory['status'], { label: string; tone: 'success' | 'warning' | 'danger' | 'neutral'; barTone: 'success' | 'warning' | 'danger' }> = {
  'on-track': { label: 'On track', tone: 'success', barTone: 'success' },
  'nearly-there': { label: 'Nearly there', tone: 'warning', barTone: 'warning' },
  'over-budget': { label: 'Over budget', tone: 'danger', barTone: 'danger' },
  unused: { label: 'Unused', tone: 'neutral', barTone: 'success' },
};

interface BudgetCategoryCardProps {
  budget: BudgetCategory;
}

export default function BudgetCategoryCard({ budget }: BudgetCategoryCardProps) {
  const cat = categories[budget.category];
  const status = statusConfig[budget.status];
  const remaining = budget.limit - budget.spent;
  const percent = (budget.spent / budget.limit) * 100;

  return (
    <Card>
      <div className={styles.header}>
        <div className={styles.title}>
          <IconIndicator icon={cat.icon} colorVar={cat.colorVar} />
          <span className={styles.label}>{cat.label}</span>
        </div>
        <Badge tone={status.tone}>{status.label}</Badge>
      </div>
      <ProgressBar value={percent} tone={status.barTone} />
      <div className={styles.footer}>
        <span>
          S${budget.spent.toFixed(0)} of S${budget.limit.toFixed(0)}
        </span>
        {budget.status === 'over-budget' ? (
          <span className={styles.over}>S${Math.abs(remaining).toFixed(0)} over</span>
        ) : budget.status === 'unused' ? (
          <span>S${remaining.toFixed(0)} left</span>
        ) : (
          <span>S${remaining.toFixed(0)} left</span>
        )}
      </div>
    </Card>
  );
}
