// An inclusive date range. Both ends are "yyyy-MM-dd" strings, the format the API and <input type="date"> use.
export interface DateRange {
  from: string;
  to: string;
}

export type RangePreset = 'this-month' | 'last-month' | 'last-3-months' | 'this-year';

// A Date as "yyyy-MM-dd" in the user's local time zone.
// toISOString() is not used because it converts to UTC and can shift the date by a day.
export function toIsoDate(d: Date): string {
  const month = String(d.getMonth() + 1).padStart(2, '0');
  const day = String(d.getDate()).padStart(2, '0');
  return `${d.getFullYear()}-${month}-${day}`;
}

// Parses "yyyy-MM-dd" as local midnight. new Date("2026-09-18") would parse as UTC instead.
function parseIsoDate(date: string): Date {
  const [year, month, day] = date.split('-').map(Number);
  return new Date(year, month - 1, day);
}

// Day 0 of a month is the last day of the previous month, and out-of-range months roll over
// into the next or previous year, so no month-length or year-boundary logic is needed.
export function getPresetRange(preset: RangePreset, today: Date = new Date()): DateRange {
  const year = today.getFullYear();
  const month = today.getMonth();

  switch (preset) {
    case 'this-month':
      return { from: toIsoDate(new Date(year, month, 1)), to: toIsoDate(new Date(year, month + 1, 0)) };
    case 'last-month':
      return { from: toIsoDate(new Date(year, month - 1, 1)), to: toIsoDate(new Date(year, month, 0)) };
    case 'last-3-months':
      return { from: toIsoDate(new Date(year, month - 2, 1)), to: toIsoDate(new Date(year, month + 1, 0)) };
    case 'this-year':
      return { from: toIsoDate(new Date(year, 0, 1)), to: toIsoDate(new Date(year, 11, 31)) };
  }
}

// e.g. "1 to 30 Sept 2026", "1 Jul to 30 Sept 2026", "1 Dec 2025 to 31 Jan 2026".
// The start date only repeats the month or year when it differs from the end date.
export function formatRangeLabel(range: DateRange): string {
  const from = parseIsoDate(range.from);
  const to = parseIsoDate(range.to);
  const sameYear = from.getFullYear() === to.getFullYear();
  const sameMonth = sameYear && from.getMonth() === to.getMonth();

  let fromOptions: Intl.DateTimeFormatOptions;
  if (sameMonth) {
    fromOptions = { day: 'numeric' };
  } else if (sameYear) {
    fromOptions = { day: 'numeric', month: 'short' };
  } else {
    fromOptions = { day: 'numeric', month: 'short', year: 'numeric' };
  }

  const fromLabel = from.toLocaleDateString('en-SG', fromOptions);
  const toLabel = to.toLocaleDateString('en-SG', { day: 'numeric', month: 'short', year: 'numeric' });
  return `${fromLabel} to ${toLabel}`;
}

// Formats a "yyyy-MM" month as a display label, e.g. "2026-09" → "September 2026".
// Splits the string rather than using new Date("2026-09"), which parses as UTC and can shift the month.
export function formatMonthLabel(month: string): string {
  const [year, monthNumber] = month.split('-').map(Number);
  return new Date(year, monthNumber - 1, 1).toLocaleDateString('en-SG', { month: 'long', year: 'numeric' });
}
