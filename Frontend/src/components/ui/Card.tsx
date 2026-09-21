import styles from './Card.module.css';

interface CardProps {
  children: React.ReactNode;
  className?: string;
  padded?: boolean;
}

export default function Card({ children, className = '', padded = true }: CardProps) {
  return (
    <div className={`${styles.card} ${padded ? styles.padded : ''} ${className}`}>
      {children}
    </div>
  );
}
