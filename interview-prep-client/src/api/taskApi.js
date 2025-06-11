import axios from './axios';

export const getMonths = () => axios.get('/months');
export const getWeeks = (monthId) => axios.get(`/months/${monthId}/weeks`);
export const getDays = (weekId) => axios.get(`/weeks/${weekId}/days`);
export const getTasks = (dayId) => axios.get(`/days/${dayId}/tasks`);
export const createTask = (data) => axios.post(`/tasks`, data);
export const updateTask = (id, data) => axios.put(`/tasks/${id}`, data);
export const deleteTask = (id) => axios.delete(`/tasks/${id}`);