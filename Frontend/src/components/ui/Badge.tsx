import styles from './Badge.module.css';

type BadgeTone = 'neutral' | 'success' | 'warning' | 'danger' | 'category';

interface BadgeProps {
  children: React.ReactNode;
  tone?: BadgeTone;
  colorVar?: string; // for category-tinted badges, e.g. '--color-food'
}

export default function Badge({ children, tone = 'neutral', colorVar }: BadgeProps) {
  const style = colorVar
    ? ({ '--badge-color': `var(${colorVar})` } as React.CSSProperties)
    : undefined;
  return (
    <span className={`${styles.badge} ${styles[tone]}`} style={style}>
      {children}
    </span>
  );
}
