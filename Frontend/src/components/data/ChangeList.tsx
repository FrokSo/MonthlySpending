import { categories } from '../../data/mockData';
import type { CategoryChange } from '../../types';
import styles from './ChangeList.module.css';

interface ChangeListProps {
  changes: CategoryChange[];
}

export default function ChangeList({ changes }: ChangeListProps) {
  return (
    <ul className={styles.list}>
      {changes.map((c) => {
        const cat = categories[c.category];
        const isPositiveChange = c.percentChange > 0;
        const isZero = c.percentChange === 0;
        return (
          <li key={c.category} className={styles.item}>
            <span className={styles.left}>
              <span className={styles.dot} style={{ background: `var(${cat.colorVar})` }} />
              {cat.label}
            </span>
            <span
              className={
                isZero ? styles.zero : isPositiveChange ? styles.up : styles.down
              }
            >
              {isZero ? '0%' : `${isPositiveChange ? '+' : ''}${c.percentChange}%`}
            </span>
          </li>
        );
      })}
    </ul>
  );
}
