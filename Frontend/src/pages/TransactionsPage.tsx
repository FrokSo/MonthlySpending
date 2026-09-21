import { useMemo, useState } from 'react';
import Card from '../components/ui/Card';
import Button from '../components/ui/Button';
import SearchInput from '../components/ui/SearchInput';
import FilterPillGroup from '../components/ui/FilterPillGroup';
import Dropdown from '../components/ui/Dropdown';
import TransactionList from '../components/data/TransactionList';
import Pagination from '../components/ui/Pagination';
import { categories, transactions, summary } from '../data/mockData';
import styles from './TransactionsPage.module.css';

const PAGE_SIZE = 6;

export default function TransactionsPage() {
  const [search, setSearch] = useState('');
  const [filter, setFilter] = useState('All');
  const [page, setPage] = useState(1);

  const filterOptions = ['All', ...Object.values(categories).filter((c) => c.id !== 'income').map((c) => c.label)];

  const filtered = useMemo(() => {
    return transactions.filter((t) => {
      const matchesSearch = t.merchant.toLowerCase().includes(search.toLowerCase());
      const matchesFilter =
        filter === 'All' || categories[t.category].label === filter;
      return matchesSearch && matchesFilter;
    });
  }, [search, filter]);

  const totalPages = Math.max(1, Math.ceil(filtered.length / PAGE_SIZE));
  const pageItems = filtered.slice((page - 1) * PAGE_SIZE, page * PAGE_SIZE);

  return (
    <div className={styles.page}>
      <div className={styles.header}>
        <div>
          <h1 className={styles.title}>Transactions</h1>
          <p className={styles.subtitle}>
            {transactions.length} entries in September, S${summary.spent.toLocaleString()} spent
          </p>
        </div>
        <Button variant="secondary">↓ Export CSV</Button>
      </div>

      <div className={styles.controls}>
        <SearchInput value={search} onChange={setSearch} placeholder="Search merchant or note" />
        <Dropdown label="1 to 30 Sep" />
      </div>

      <FilterPillGroup options={filterOptions} value={filter} onChange={setFilter} />

      <Card>
        <TransactionList transactions={pageItems} showCategoryBadge groupByDate />
      </Card>

      <div className={styles.footer}>
        <span className={styles.count}>
          Showing {(page - 1) * PAGE_SIZE + 1} to {Math.min(page * PAGE_SIZE, filtered.length)} of{' '}
          {filtered.length}
        </span>
        <Pagination page={page} totalPages={totalPages} onChange={setPage} />
      </div>
    </div>
  );
}
