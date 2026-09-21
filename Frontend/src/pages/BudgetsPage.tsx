import Card from '../components/ui/Card';
import ProgressBar from '../components/ui/ProgressBar';
import Badge from '../components/ui/Badge';
import BudgetCategoryCard from '../components/data/BudgetCategoryCard';
import { budgets, summary } from '../data/mockData';
import styles from './BudgetsPage.module.css';

export default function BudgetsPage() {
  const totalSpent = budgets.reduce((sum, b) => sum + b.spent, 0);
  const percentUsed = Math.round((totalSpent / summary.budget) * 100);
  const pacePercent = (18 / 30) * 100; // day 18 of 30, matching design's "day 19 of 30" marker roughly

  return (
    <div className={styles.page}>
      <h1 className={styles.title}>Budgets for September</h1>

      <Card>
        <div className={styles.overviewHeader}>
          <div>
            <span className={styles.overviewValue}>S${totalSpent.toLocaleString()}</span>
            <span className={styles.overviewOf}> of S${summary.budget.toLocaleString()}</span>
          </div>
          <Badge tone="warning">10 points ahead of pace</Badge>
        </div>
        <ProgressBar value={percentUsed} tone="warning" markerAt={pacePercent} />
        <div className={styles.overviewFooter}>
          <span>{percentUsed}% used</span>
          <span>Marker: where you'd be on an even pace (day 19 of 30)</span>
        </div>
      </Card>

      <div className={styles.grid}>
        {budgets.map((b) => (
          <BudgetCategoryCard key={b.category} budget={b} />
        ))}
        <button className={styles.addCategory}>+ Add a category budget</button>
      </div>
    </div>
  );
}
