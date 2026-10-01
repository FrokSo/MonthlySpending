import { useState } from 'react';
import { getPresetRange, type DateRange, type RangePreset } from '../../utils/date';
import styles from './DateRangePicker.module.css';

type Option = RangePreset | 'custom';

const OPTIONS: { value: Option; label: string }[] = [
  { value: 'this-month', label: 'This month' },
  { value: 'last-month', label: 'Last month' },
  { value: 'last-3-months', label: 'Last 3 months' },
  { value: 'this-year', label: 'This year' },
  { value: 'custom', label: 'Custom range…' },
];

interface DateRangePickerProps {
  value: DateRange;
  onChange: (range: DateRange) => void;
  // Which option is selected on first render. It should match the range the parent starts with.
  initialPreset?: RangePreset;
}

export default function DateRangePicker({ value, onChange, initialPreset = 'this-month' }: DateRangePickerProps) {
  const [selected, setSelected] = useState<Option>(initialPreset);

  function handleSelect(option: Option) {
    setSelected(option);
    // Custom keeps the current range, so the date inputs start from what was already showing.
    if (option !== 'custom') {
      onChange(getPresetRange(option));
    }
  }

  // An emptied date input reports "", which is ignored so the range is never left half-set.
  // If one end moves past the other, the other end follows, so "from" is never after "to".
  function handleFromChange(from: string) {
    if (!from) {
      return;
    }
    onChange({ from, to: from > value.to ? from : value.to });
  }

  function handleToChange(to: string) {
    if (!to) {
      return;
    }
    onChange({ from: to < value.from ? to : value.from, to });
  }

  return (
    <div className={styles.wrap}>
      <select
        className={styles.select}
        value={selected}
        onChange={(e) => handleSelect(e.target.value as Option)}
        aria-label="Date range"
      >
        {OPTIONS.map((option) => (
          <option key={option.value} value={option.value}>
            {option.label}
          </option>
        ))}
      </select>

      {selected === 'custom' && (
        <>
          <input
            type="date"
            className={styles.dateInput}
            value={value.from}
            max={value.to}
            onChange={(e) => handleFromChange(e.target.value)}
            aria-label="From date"
          />
          <span className={styles.separator}>to</span>
          <input
            type="date"
            className={styles.dateInput}
            value={value.to}
            min={value.from}
            onChange={(e) => handleToChange(e.target.value)}
            aria-label="To date"
          />
        </>
      )}
    </div>
  );
}
