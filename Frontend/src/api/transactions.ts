import type { NewTransaction, Transaction } from '../types';
import { getJson, deleteJson, postJson } from './client';

export function fetchAllTransactions(signal?: AbortSignal) {
  return getJson<Transaction[]>('/transactions/all', signal);
}

export function fetchTransactionsByRange(startDate: string, endDate: string, signal? : AbortSignal)
{
  const query = new URLSearchParams({startDate, endDate});
  return getJson<Transaction[]>(`/transactions/range?${query}`, signal);
}

export function deleteTransaction(id: string, signal?: AbortSignal)
{
  return deleteJson(`/transactions/${id}`, signal);
}

export function createTransaction(newTransaction: NewTransaction, signal?: AbortSignal)
{
  return postJson<Transaction>(`/transactions`, newTransaction, signal);
}