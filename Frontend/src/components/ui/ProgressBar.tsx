import styles from './ProgressBar.module.css';

type ProgressTone = 'success' | 'warning' | 'danger';

interface ProgressBarProps {
  value: number; // 0-100+
  tone?: ProgressTone;
  markerAt?: number; // optional pace marker, 0-100
}

export default function ProgressBar({ value, tone = 'success', markerAt }: ProgressBarProps) {
  const clamped = Math.min(value, 100);
  return (
    <div className={styles.track}>
      <div className={`${styles.fill} ${styles[tone]}`} style={{ width: `${clamped}%` }} />
      {markerAt !== undefined && (
        <div className={styles.marker} style={{ left: `${Math.min(markerAt, 100)}%` }} />
      )}
    </div>
  );
}
