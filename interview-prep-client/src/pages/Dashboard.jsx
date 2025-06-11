import { useEffect, useState } from 'react';
import Layout from '../components/Layout';
import MonthSelector from '../components/MonthSelector';
import WeekSelector from '../components/WeekSelector';
import DaySelector from '../components/DaySelector';
import TaskList from '../components/TaskList';
import ProgressBar from '../components/ProgressBar';
import ThemeToggle from '../components/ThemeToggle';
import * as api from '../api/taskApi';

export default function Dashboard() {
  const [months, setMonths] = useState([]);
  const [weeks, setWeeks] = useState([]);
  const [days, setDays] = useState([]);
  const [tasks, setTasks] = useState([]);
  const [darkMode, setDarkMode] = useState(false);

  const [selectedMonth, setSelectedMonth] = useState('');
  const [selectedWeek, setSelectedWeek] = useState('');
  const [selectedDay, setSelectedDay] = useState('');

  useEffect(() => { api.getMonths().then(res => setMonths(res.data)); }, []);
  useEffect(() => { selectedMonth && api.getWeeks(selectedMonth).then(res => setWeeks(res.data)); }, [selectedMonth]);
  useEffect(() => { selectedWeek && api.getDays(selectedWeek).then(res => setDays(res.data)); }, [selectedWeek]);
  useEffect(() => { selectedDay && api.getTasks(selectedDay).then(res => setTasks(res.data)); }, [selectedDay]);

  const toggleTask = async (task) => {
    await api.updateTask(task.id, { ...task, isCompleted: !task.isCompleted });
    setTasks(tasks.map(t => t.id === task.id ? { ...t, isCompleted: !t.isCompleted } : t));
  };

  const deleteTask = async (id) => {
    await api.deleteTask(id);
    setTasks(tasks.filter(t => t.id !== id));
  };

  return (
    <Layout darkMode={darkMode}>
      <ThemeToggle darkMode={darkMode} toggleMode={() => setDarkMode(!darkMode)} />
      <MonthSelector months={months} onChange={setSelectedMonth} />
      <WeekSelector weeks={weeks} onChange={setSelectedWeek} />
      <DaySelector days={days} onChange={setSelectedDay} />
      <ProgressBar tasks={tasks} />
      <TaskList tasks={tasks} onToggle={toggleTask} onDelete={deleteTask} />
    </Layout>
  );
}