import styles from './Dropdown.module.css';

interface DropdownProps {
  label: string;
  onPrev?: () => void;
  onNext?: () => void;
}

export default function Dropdown({ label, onPrev, onNext }: DropdownProps) {
  return (
    <div className={styles.wrap}>
      {onPrev && (
        <button className={styles.arrow} onClick={onPrev} aria-label="Previous">
          ‹
        </button>
      )}
      <span className={styles.label}>{label}</span>
      {onNext && (
        <button className={styles.arrow} onClick={onNext} aria-label="Next">
          ›
        </button>
      )}
    </div>
  );
}
