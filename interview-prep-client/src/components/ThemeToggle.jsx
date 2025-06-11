export default function ThemeToggle({ darkMode, toggleMode }) {
    return (
      <div className="form-check form-switch mb-3">
        <input
          className="form-check-input"
          type="checkbox"
          checked={darkMode}
          onChange={toggleMode}
          id="themeSwitch"
        />
        <label className="form-check-label" htmlFor="themeSwitch">
          {darkMode ? 'Dark' : 'Light'} Mode
        </label>
      </div>
    );
  }  