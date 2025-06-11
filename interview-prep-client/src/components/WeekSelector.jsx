export default function WeekSelector({ weeks, onChange }) {
    return (
      <select className="form-select mb-3" onChange={(e) => onChange(e.target.value)}>
        <option>Select Week</option>
        {weeks.map(week => (
          <option key={week.id} value={week.id}>Week {week.weekNumber}</option>
        ))}
      </select>
    );
  }
  