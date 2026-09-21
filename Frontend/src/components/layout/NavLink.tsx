import { NavLink as RouterNavLink } from 'react-router-dom';
import styles from './NavLink.module.css';

interface NavLinkProps {
  to: string;
  children: React.ReactNode;
}

export default function NavLink({ to, children }: NavLinkProps) {
  return (
    <RouterNavLink
      to={to}
      className={({ isActive }) => (isActive ? `${styles.link} ${styles.active}` : styles.link)}
    >
      {children}
    </RouterNavLink>
  );
}
