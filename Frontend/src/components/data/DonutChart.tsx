import { PieChart, Pie, Cell } from 'recharts';
import { categories } from '../../data/categories';
import type { CategoryId } from '../../types';
import styles from './DonutChart.module.css';

interface DonutChartProps {
  data: { category: CategoryId; amount: number }[];
  centerLabel: string;
  centerValue: string;
}

export default function DonutChart({ data, centerLabel, centerValue }: DonutChartProps) {
  const chartData = data.map((d) => ({
    name: categories[d.category].label,
    value: d.amount,
    color: `var(${categories[d.category].colorVar})`,
  }));

  return (
    <div className={styles.wrap}>
      <div className={styles.chartArea}>
        <PieChart width={140} height={140}>
          <Pie
            data={chartData}
            dataKey="value"
            innerRadius={45}
            outerRadius={65}
            paddingAngle={2}
            stroke="none"
          >
            {chartData.map((entry, i) => (
              <Cell key={i} fill={entry.color} />
            ))}
          </Pie>
        </PieChart>
        <div className={styles.center}>
          <div className={styles.centerValue}>{centerValue}</div>
          <div className={styles.centerLabel}>{centerLabel}</div>
        </div>
      </div>
      <ul className={styles.legend}>
        {data.map((d) => (
          <li key={d.category} className={styles.legendItem}>
            <span
              className={styles.dot}
              style={{ background: `var(${categories[d.category].colorVar})` }}
            />
            <span className={styles.legendLabel}>{categories[d.category].label}</span>
            <span className={styles.legendValue}>S${d.amount.toFixed(0)}</span>
          </li>
        ))}
      </ul>
    </div>
  );
}
