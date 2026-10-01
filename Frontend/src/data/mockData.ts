import type {
  Transaction,
  BudgetCategory,
  DailySpendPoint,
  MonthlySpendPoint,
  CategoryChange,
} from '../types';

export const transactions: Transaction[] = [
  { id: 't1', date: '2026-09-18', merchant: 'Din Tai Fung', category: 'food', paymentMethod: 'Credit card', amount: -46.2 },
  { id: 't2', date: '2026-09-18', merchant: 'NTUC FairPrice', category: 'food', paymentMethod: 'PayNow', amount: -62.35 },
  { id: 't3', date: '2026-09-17', merchant: 'Grab ride', category: 'transport', paymentMethod: 'Credit card', amount: -14.8 },
  { id: 't4', date: '2026-09-15', merchant: 'SP Services', category: 'bills', paymentMethod: 'GIRO', amount: -118.4 },
  { id: 't5', date: '2026-09-14', merchant: 'Uniqlo', category: 'shopping', paymentMethod: 'Credit card', amount: -89.9 },
  { id: 't6', date: '2026-09-01', merchant: 'Salary', category: 'income', paymentMethod: 'Bank transfer', amount: 5200 },
];

export const budgets: BudgetCategory[] = [
  { category: 'food', spent: 699, limit: 750, status: 'nearly-there' },
  { category: 'housing', spent: 612, limit: 700, status: 'on-track' },
  { category: 'transport', spent: 306, limit: 400, status: 'on-track' },
  { category: 'shopping', spent: 349, limit: 300, status: 'over-budget' },
  { category: 'bills', spent: 218, limit: 300, status: 'on-track' },
  { category: 'other', spent: 0, limit: 550, status: 'unused' },
];

export const dailySpend: DailySpendPoint[] = [
  { date: '1 Sep', amount: 60 }, { date: '2 Sep', amount: 110 }, { date: '3 Sep', amount: 95 },
  { date: '4 Sep', amount: 312 }, { date: '5 Sep', amount: 45 }, { date: '6 Sep', amount: 70 },
  { date: '7 Sep', amount: 130 }, { date: '8 Sep', amount: 88 }, { date: '9 Sep', amount: 150 },
  { date: '10 Sep', amount: 72 }, { date: '11 Sep', amount: 140 }, { date: '12 Sep', amount: 55 },
];

export const monthlySpend: MonthlySpendPoint[] = [
  { month: 'Apr', amount: 2410 },
  { month: 'May', amount: 2650 },
  { month: 'Jun', amount: 2290 },
  { month: 'Jul', amount: 2730 },
  { month: 'Aug', amount: 2323 },
  { month: 'Sep', amount: 2184 },
];

export const categoryChanges: CategoryChange[] = [
  { category: 'food', percentChange: 4 },
  { category: 'housing', percentChange: 0 },
  { category: 'transport', percentChange: -12 },
  { category: 'shopping', percentChange: 38 },
  { category: 'bills', percentChange: -3 },
];

export const summary = {
  income: 5200,
  spent: 2184,
  budget: 3000,
  vsLastMonthPercent: -6,
  daysLeftInMonth: 11,
  currentMonth: 'September 2026',
  savedThisMonth: 3016,
  savedPercentOfIncome: 58,
  topMerchant: 'NTUC FairPrice',
  topMerchantAmount: 214,
  topMerchantVisits: 6,
};
