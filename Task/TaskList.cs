using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
     public class Tasklist 
    {
        private string name;
        private List<Task> tasks;

        /// <summary>
        /// Создаёт объект TaskList
        /// </summary>
        public Tasklist(string name)
        {
            this.name = name;
            tasks = new List<Task>();
        }
         /// <symmary>
         /// Возвращает имя списка задач
         /// </symmary>
         public string GetName()
        {
            return name;
        }
        /// <summary>
        /// Добавляет задачу в список задач
        /// </summary>
         public void AddTask(Task task)
        {
            tasks.Add(task);
        }
        /// <summary>
        /// Возвращает список всех задач
        /// </summary>
        public List<Task> GetTasks()
        {
            return tasks;
        }
        /// <summary>
        /// Удаляет задачу из списка задач
        /// </summary>
        public void Remove(Task task)
        {
            tasks.Remove(task);
        }
        /// <summary>
        /// Возвращает список заддач в хронологическом порядке
        /// </summary>
        /// 
        
    }
}
