import styles from './FilterPillGroup.module.css';

interface FilterPillGroupProps {
  options: string[];
  value: string;
  onChange: (value: string) => void;
}

export default function FilterPillGroup({ options, value, onChange }: FilterPillGroupProps) {
  return (
    <div className={styles.group}>
      {options.map((opt) => (
        <button
          key={opt}
          className={opt === value ? `${styles.pill} ${styles.active}` : styles.pill}
          onClick={() => onChange(opt)}
        >
          {opt}
        </button>
      ))}
    </div>
  );
}
