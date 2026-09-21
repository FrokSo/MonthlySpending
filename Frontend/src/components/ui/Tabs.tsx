import styles from './Tabs.module.css';

interface TabsProps {
  options: string[];
  value: string;
  onChange: (value: string) => void;
}

export default function Tabs({ options, value, onChange }: TabsProps) {
  return (
    <div className={styles.tabs}>
      {options.map((opt) => (
        <button
          key={opt}
          className={opt === value ? `${styles.tab} ${styles.active}` : styles.tab}
          onClick={() => onChange(opt)}
        >
          {opt}
        </button>
      ))}
    </div>
  );
}
