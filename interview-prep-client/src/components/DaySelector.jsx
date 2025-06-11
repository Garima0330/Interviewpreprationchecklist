export default function DaySelector({ days, onChange }) {
    return (
      <select className="form-select mb-3" onChange={(e) => onChange(e.target.value)}>
        <option>Select Day</option>
        {days.map(day => (
          <option key={day.id} value={day.id}>{new Date(day.date).toDateString()}</option>
        ))}
      </select>
    );
  }
  