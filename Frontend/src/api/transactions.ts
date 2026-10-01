import type { Transaction } from '../types';
import { getJson } from './client';

export function fetchTransactions(signal?: AbortSignal) {
  return getJson<Transaction[]>('/transactions', signal);
}
