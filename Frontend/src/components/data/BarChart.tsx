import { BarChart as ReBarChart, Bar, ResponsiveContainer, Cell, XAxis } from 'recharts';
import styles from './BarChart.module.css';

interface BarChartProps {
  data: { label: string; value: number }[];
  highlightIndex?: number;
  showAllLabels?: boolean;
}

export default function BarChart({ data, highlightIndex, showAllLabels = false }: BarChartProps) {
  return (
    <div className={styles.wrap}>
      <ResponsiveContainer width="100%" height={160}>
        <ReBarChart data={data}>
          <Bar dataKey="value" radius={[4, 4, 0, 0]}>
            {data.map((_, i) => (
              <Cell
                key={i}
                fill={i === highlightIndex ? 'var(--color-primary)' : 'var(--color-primary-light)'}
              />
            ))}
          </Bar>
          {showAllLabels && (
            <XAxis dataKey="label" axisLine={false} tickLine={false} fontSize={11} />
          )}
        </ReBarChart>
      </ResponsiveContainer>
      {!showAllLabels && (
        <div className={styles.axisRow}>
          <span>{data[0]?.label}</span>
          {highlightIndex !== undefined && data[highlightIndex] && (
            <span className={styles.peak}>
              Peak, {data[highlightIndex].label}
            </span>
          )}
          <span>{data[data.length - 1]?.label}</span>
        </div>
      )}
    </div>
  );
}
