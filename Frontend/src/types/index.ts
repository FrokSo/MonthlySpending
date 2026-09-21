export type CategoryId =
  | 'food'
  | 'housing'
  | 'transport'
  | 'shopping'
  | 'bills'
  | 'other'
  | 'income';

export interface Category {
  id: CategoryId;
  label: string;
  colorVar: string;
  icon: string;
}

export type BudgetStatus = 'on-track' | 'nearly-there' | 'over-budget' | 'unused';

export interface Transaction {
  id: string;
  date: string; // ISO date
  merchant: string;
  note?: string;
  category: CategoryId;
  paymentMethod: string;
  amount: number; // negative = expense, positive = income
}

export interface BudgetCategory {
  category: CategoryId;
  spent: number;
  limit: number;
  status: BudgetStatus;
}

export interface DailySpendPoint {
  date: string;
  amount: number;
}

export interface MonthlySpendPoint {
  month: string;
  amount: number;
}

export interface CategoryChange {
  category: CategoryId;
  percentChange: number;
}
