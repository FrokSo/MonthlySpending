import type { Category } from '../types';

export const categories: Record<string, Category> = {
  food: { id: 'food', label: 'Food', colorVar: '--color-food', icon: '🍽️' },
  housing: { id: 'housing', label: 'Housing', colorVar: '--color-housing', icon: '🏠' },
  transport: { id: 'transport', label: 'Transport', colorVar: '--color-transport', icon: '🚌' },
  shopping: { id: 'shopping', label: 'Shopping', colorVar: '--color-shopping', icon: '🛍️' },
  bills: { id: 'bills', label: 'Bills', colorVar: '--color-bills', icon: '⚡' },
  other: { id: 'other', label: 'Other', colorVar: '--color-other', icon: '⋯' },
  income: { id: 'income', label: 'Income', colorVar: '--color-primary', icon: '↙' },
};
