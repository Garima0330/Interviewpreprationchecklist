export default function ProgressBar({ tasks }) {
    const total = tasks.length;
    const completed = tasks.filter(t => t.isCompleted).length;
    const percent = total === 0 ? 0 : Math.round((completed / total) * 100);
  
    return (
      <div className="mb-3">
        <div className="progress">
          <div
            className="progress-bar"
            role="progressbar"
            style={{ width: `${percent}%` }}
          >
            {percent}%
          </div>
        </div>
      </div>
    );
  }
  