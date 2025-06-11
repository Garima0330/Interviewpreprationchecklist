export default function Layout({ children, darkMode }) {
    return (
      <div className={`min-vh-100 ${darkMode ? 'bg-dark text-white' : 'bg-light text-dark'}`}>
        <div className="container py-4">
          <h1 className="mb-4">📋 Interview Preparation Planner</h1>
          {children}
        </div>
      </div>
    );
  }  