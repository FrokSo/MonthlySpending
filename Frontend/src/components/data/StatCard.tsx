import Card from '../ui/Card';
import styles from './StatCard.module.css';

interface StatCardProps {
  label: string;
  value: string;
  sublabel?: string;
  trend?: string;
  emphasis?: boolean;
}

export default function StatCard({ label, value, sublabel, trend, emphasis }: StatCardProps) {
  return (
    <Card className={emphasis ? styles.emphasis : ''}>
      <div className={styles.label}>{label}</div>
      <div className={styles.value}>{value}</div>
      {sublabel && <div className={styles.sublabel}>{sublabel}</div>}
      {trend && <div className={styles.trend}>{trend}</div>}
    </Card>
  );
}
