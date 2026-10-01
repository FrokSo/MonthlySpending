import type { Transaction } from '../types';
import { getJson } from './client';

export function fetchAllTransactions(signal?: AbortSignal) {
  return getJson<Transaction[]>('/transactions/all', signal);
}

export function fetchTransactionsByRange(startDate: string, endDate: string, signal? : AbortSignal)
{
  const query = new URLSearchParams({startDate, endDate});
  return getJson<Transaction[]>(`/transactions/range?${query}`, signal);

}