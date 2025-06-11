export default function TaskList({ tasks, onToggle, onDelete }) {
    return (
      <ul className="list-group mb-3">
        {tasks.map(task => (
          <li key={task.id} className="list-group-item d-flex justify-content-between align-items-center">
            <div>
              <input
                type="checkbox"
                checked={task.isCompleted}
                onChange={() => onToggle(task)}
                className="form-check-input me-2"
              />
              <span className={task.isCompleted ? 'text-decoration-line-through' : ''}>{task.title}</span>
            </div>
            <button className="btn btn-sm btn-danger" onClick={() => onDelete(task.id)}>Delete</button>
          </li>
        ))}
      </ul>
    );
  }  