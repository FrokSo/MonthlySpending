import { createContext, useContext, useState, type ReactNode } from 'react';

interface TransactionsContextValue{
    version: number;
    notifyChange: () => void;
}

const TransactionsContext = createContext<TransactionsContextValue | null>(null);

interface TransactionsProviderProps {
  children: ReactNode;
}

export function TransactionsProvider({ children }: TransactionsProviderProps) {
  const [version, setVersion] = useState(0);

  function notifyChange() {
    setVersion((prev) => prev + 1);
  }

  return <TransactionsContext value={{ version, notifyChange }}>{children}</TransactionsContext>;
}

export function useTransactionsChanged() {
  const context = useContext(TransactionsContext);
  if (context === null) {
    throw new Error('useTransactionsChanged must be used inside TransactionsProvider');
  }
  return context;
}