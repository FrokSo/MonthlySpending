import NavBar from './NavBar';
import styles from './AppShell.module.css';

interface AppShellProps {
  children: React.ReactNode;
}

export default function AppShell({ children }: AppShellProps) {
  return (
    <div className={styles.shell}>
      <NavBar />
      <main className={styles.content}>{children}</main>
    </div>
  );
}
