import styles from './Avatar.module.css';

interface AvatarProps {
  initial: string;
}

export default function Avatar({ initial }: AvatarProps) {
  return <div className={styles.avatar}>{initial}</div>;
}
