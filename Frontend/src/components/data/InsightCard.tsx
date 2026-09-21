import Card from '../ui/Card';
import styles from './InsightCard.module.css';

interface InsightCardProps {
  label: string;
  value?: string;
  sublabel?: string;
  tone?: 'neutral' | 'warning';
}

export default function InsightCard({ label, value, sublabel, tone = 'neutral' }: InsightCardProps) {
  return (
    <Card className={tone === 'warning' ? styles.warning : ''}>
      <div className={styles.label}>{label}</div>
      {value && <div className={styles.value}>{value}</div>}
      {sublabel && <div className={styles.sublabel}>{sublabel}</div>}
    </Card>
  );
}
