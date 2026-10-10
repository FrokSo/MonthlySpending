import { useState } from 'react';
import NavLink from './NavLink';
import Button from '../ui/Button';
import Avatar from '../ui/Avatar';
import Modal from '../ui/Modal';
import styles from './NavBar.module.css';
import AddTransactionForm from '../data/AddTransactionForm';

export default function NavBar() {
  const [isAddOpen, setIsAddOpen] = useState(false);


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
        <Button variant="primary" onClick={() => setIsAddOpen(true)}>
          + Add expense
        </Button>
        <Avatar initial="R" />
      </div>
      {isAddOpen && (
        <Modal title="Add expense" onClose={() => setIsAddOpen(false)}>
          <AddTransactionForm onSave={() => setIsAddOpen(false)} 
                              onCancel={() => setIsAddOpen(false)}/>
        </Modal>
      )}
    </header>
  );
}
