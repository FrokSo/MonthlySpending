import NavLink from './NavLink';
import Button from '../ui/Button';
import Avatar from '../ui/Avatar';
import styles from './NavBar.module.css';

export default function NavBar() {
  return (
    <header className={styles.nav}>
      <div className={styles.left}>
        <div className={styles.logo}>
          <span className={styles.logoMark}>🧾</span>
          <span className={styles.logoText}>Thrifty</span>
        </div>
        <nav className={styles.links}>
          <NavLink to="/">Dashboard</NavLink>
          <NavLink to="/transactions">Transactions</NavLink>
          <NavLink to="/budgets">Budgets</NavLink>
          <NavLink to="/reports">Reports</NavLink>
        </nav>
      </div>
      <div className={styles.right}>
        <Button variant="primary">+ Add expense</Button>
        <Avatar initial="R" />
      </div>
    </header>
  );
}
