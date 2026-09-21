import styles from './IconIndicator.module.css';

interface IconIndicatorProps {
  icon: string;
  colorVar: string;
}

export default function IconIndicator({ icon, colorVar }: IconIndicatorProps) {
  return (
    <div className={styles.wrap} style={{ '--icon-color': `var(${colorVar})` } as React.CSSProperties}>
      <span>{icon}</span>
    </div>
  );
}
