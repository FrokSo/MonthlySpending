import styles from './Pagination.module.css';

interface PaginationProps {
  page: number;
  totalPages: number;
  onChange: (page: number) => void;
}

export default function Pagination({ page, totalPages, onChange }: PaginationProps) {
  return (
    <div className={styles.wrap}>
      <button
        className={styles.navButton}
        disabled={page <= 1}
        onClick={() => onChange(page - 1)}
      >
        Previous
      </button>
      {Array.from({ length: totalPages }, (_, i) => i + 1).map((p) => (
        <button
          key={p}
          className={p === page ? `${styles.pageButton} ${styles.active}` : styles.pageButton}
          onClick={() => onChange(p)}
        >
          {p}
        </button>
      ))}
      <button
        className={styles.navButton}
        disabled={page >= totalPages}
        onClick={() => onChange(page + 1)}
      >
        Next
      </button>
    </div>
  );
}
