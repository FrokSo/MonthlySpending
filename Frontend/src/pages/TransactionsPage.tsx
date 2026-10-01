import { useEffect, useMemo, useState } from 'react';
import Card from '../components/ui/Card';
import Button from '../components/ui/Button';
import SearchInput from '../components/ui/SearchInput';
import FilterPillGroup from '../components/ui/FilterPillGroup';
import DateRangePicker from '../components/ui/DateRangePicker';
import TransactionList from '../components/data/TransactionList';
import Pagination from '../components/ui/Pagination';
import { categories } from '../data/categories';
import { fetchTransactionsByRange } from '../api/transactions';
import type { Transaction } from '../types';
import { formatRangeLabel, getPresetRange, type DateRange } from '../utils/date';
import styles from './TransactionsPage.module.css';

const PAGE_SIZE = 20;

export default function TransactionsPage() {
  const [search, setSearch] = useState('');
  const [filter, setFilter] = useState('All');
  const [page, setPage] = useState(1);
  const [transactions, setTransactions] = useState<Transaction[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);
  const [range, setRange] = useState<DateRange>(() => getPresetRange('this-month'));

  useEffect(() => {
    // Aborting on cleanup cancels the previous range's request when the range changes,
    // and also covers StrictMode's double-run of effects in development.
    const controller = new AbortController();
    fetchTransactionsByRange(range.from, range.to, controller.signal)
      .then(setTransactions)
      .catch((err: unknown) => {
        if (!controller.signal.aborted) {
          setError(err instanceof Error ? err.message : String(err));
        }
      })
      .finally(() => {
        if (!controller.signal.aborted) {
          setLoading(false);
        }
      });
    return () => controller.abort();
  }, [range]);

  // Total expenses in the range as a positive number; income is excluded.
  const spent = useMemo(() => {
    return -transactions.filter((t) => t.amount < 0).reduce((sum, t) => sum + t.amount, 0);
  }, [transactions]);

  const filterOptions = ['All', ...Object.values(categories).filter((c) => c.id !== 'income').map((c) => c.label)];

  const filtered = useMemo(() => {
    return transactions.filter((t) => {
      const matchesSearch = t.merchant.toLowerCase().includes(search.toLowerCase());
      const matchesFilter =
        filter === 'All' || categories[t.category].label === filter;
      return matchesSearch && matchesFilter;
    });
  }, [transactions, search, filter]);

  const totalPages = Math.max(1, Math.ceil(filtered.length / PAGE_SIZE));
  const pageItems = filtered.slice((page - 1) * PAGE_SIZE, page * PAGE_SIZE);

  return (
    <div className={styles.page}>
      <div className={styles.header}>
        <div>
          <h1 className={styles.title}>Transactions</h1>
          <p className={styles.subtitle}>
            {transactions.length} entries, {formatRangeLabel(range)}, S$
            {spent.toLocaleString('en-SG', { minimumFractionDigits: 2, maximumFractionDigits: 2 })} spent
          </p>
        </div>
        <Button variant="secondary">↓ Export CSV</Button>
      </div>

      <div className={styles.controls}>
        <SearchInput  value={search} 
                      onChange={(value) => {
                        setSearch(value);
                        setPage(1)
                        }} 
                      placeholder="Search merchant or note" />
        <DateRangePicker
          value={range}
          onChange={(value) => {
            // Reset here, in the event, rather than in the fetch effect. Loading already starts as true for the first fetch.
            setRange(value);
            setPage(1);
            setLoading(true);
            setError(null);
          }}
        />
      </div>

      <FilterPillGroup options={filterOptions} value={filter} onChange={setFilter} />

      <Card>
        {loading ? (
          <p className={styles.status}>Loading transactions…</p>
        ) : error ? (
          <p className={styles.status}>Couldn't load transactions: {error}</p>
        ) : filtered.length === 0 ?(
          <p className={styles.status}>No transactions found...</p>
        ) : (
          <TransactionList transactions={pageItems} showCategoryBadge groupByDate />
        )}
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
