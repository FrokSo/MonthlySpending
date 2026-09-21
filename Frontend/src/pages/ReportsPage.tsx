import { useState } from 'react';
import Card from '../components/ui/Card';
import Tabs from '../components/ui/Tabs';
import BarChart from '../components/data/BarChart';
import ChangeList from '../components/data/ChangeList';
import InsightCard from '../components/data/InsightCard';
import { monthlySpend, categoryChanges, summary } from '../data/mockData';
import styles from './ReportsPage.module.css';

export default function ReportsPage() {
  const [range, setRange] = useState('6M');
  const average = Math.round(monthlySpend.reduce((s, m) => s + m.amount, 0) / monthlySpend.length);
  const currentIndex = monthlySpend.length - 1;

  return (
    <div className={styles.page}>
      <div className={styles.header}>
        <h1 className={styles.title}>Reports</h1>
        <Tabs options={['3M', '6M', '12M']} value={range} onChange={setRange} />
      </div>

      <Card>
        <div className={styles.chartHeader}>
          <h2 className={styles.cardTitle}>Monthly spending</h2>
          <div className={styles.chartMeta}>
            <span>Average S${average.toLocaleString()}</span>
            <span className={styles.budgetLabel}>Budget S${summary.budget.toLocaleString()}</span>
          </div>
        </div>
        <BarChart
          data={monthlySpend.map((m) => ({ label: m.month, value: m.amount }))}
          highlightIndex={currentIndex}
          showAllLabels
        />
      </Card>

      <div className={styles.grid2}>
        <Card>
          <h2 className={styles.cardTitle}>Change vs August</h2>
          <ChangeList changes={categoryChanges} />
        </Card>
        <div className={styles.insightsColumn}>
          <InsightCard
            label="Saved this month"
            value={`S$${summary.savedThisMonth.toLocaleString()}`}
            sublabel={`${summary.savedPercentOfIncome}% of income`}
          />
          <InsightCard
            label="Top merchant"
            value={summary.topMerchant}
            sublabel={`S$${summary.topMerchantAmount} across ${summary.topMerchantVisits} visits`}
          />
          <InsightCard
            label="Worth a look"
            value="Shopping is up 38% and over budget"
            tone="warning"
          />
        </div>
      </div>
    </div>
  );
}
