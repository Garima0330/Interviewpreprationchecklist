export default function MonthSelector({ months, onChange }) {
    return (
      <select className="form-select mb-3" onChange={(e) => onChange(e.target.value)}>
        <option>Select Month</option>
        {months.map(month => (
          <option key={month.id} value={month.id}>{month.name}</option>
        ))}
      </select>
    );
  }  