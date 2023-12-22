using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace TaskManager
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonFile = "tasks.json";

            List<Task> tasks = new List<Task>();

            while (true)
            {
                // Отображает меню для выбора действия
                ShowMenu();

                int choice = int.Parse(Console.ReadLine());

                // Выполняет выбранное действие
                switch (choice)
                {
                    case 1:
                        AddTask(tasks);
                        break;
                    case 2:
                        DeleteTask(tasks);
                        break;
                    case 3:
                        EditTask(tasks);
                        break;
                    case 4:
                        ShowTasksByDate(tasks, DateTime.Today);
                        break;
                    case 5:
                        ShowTasksByDate(tasks, DateTime.Today.AddDays(1));
                        break;
                    case 6:
                        ShowTasksByDate(tasks, DateTime.Today.AddDays(7));
                        break;
                    case 7:
                        ShowAllTasks(tasks);
                        break;
                    case 8:
                        ShowTasksToDo(tasks);
                        break;
                    case 9:
                        ShowTasksDone(tasks);
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Некорректный выбор");
                        break;
                }
            }
        }

        // Отображает меню для пользователя
        static void ShowMenu()
        {
            Console.WriteLine("1. Добавить задачу");
            Console.WriteLine("2. Удалить задачу");
            Console.WriteLine("3. Редактировать задачу");
            Console.WriteLine("4. Посмотреть задачи на сегодня");
            Console.WriteLine("5. Посмотреть задачи на завтра");
            Console.WriteLine("6. Посмотреть задачи на неделю");
            Console.WriteLine("7. Посмотреть все задачи");
            Console.WriteLine("8. Посмотреть задачи, которые еще предстоит выполнить");
            Console.WriteLine("9. Посмотреть задачи, которые уже были выполнены");
            Console.WriteLine("0. Выход");
        }

        // Добавляет задачу в список задач
        static void AddTask(List<Task> tasks)
        {
            Console.WriteLine("Введите название задачи:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите описание задачи:");
            string description = Console.ReadLine();
            Console.WriteLine("Введите дату выполнения задачи (формат: dd.MM.yyyy):");
            string dateString = Console.ReadLine();
            DateTime date;
            if (!DateTime.TryParse(dateString, out date))
            {
                Console.WriteLine("Некорректная дата");
                return;
            }

            Task task = new Task { Name = name, Description = description, Date = date };
            tasks.Add(task);

            SaveTasks(tasks);
        }

        // Удаляет задачу из списка задач
        static void DeleteTask(List<Task> tasks)
        {
            Console.WriteLine("Введите название задачи, которую вы хотите удалить:");
            string name = Console.ReadLine();
            Task task = tasks.Find(t => t.Name == name);
            if (task != null)
            {
                tasks.Remove(task);
                SaveTasks(tasks);
            }
            else
            {
                Console.WriteLine("Задачи с таким названием не найдена");
            }
        }

        // Редактирует задачу в списке задач
        static void EditTask(List<Task> tasks)
        {
            Console.WriteLine("Введите название задачи, которую вы хотите редактировать:");
            string name = Console.ReadLine();
            Task task = tasks.Find(t => t.Name == name);
            if (task != null)
            {
                Console.WriteLine("Введите новое название задачи:");
                task.Name = Console.ReadLine();
                Console.WriteLine("Введите новое описание задачи:");
                task.Description = Console.ReadLine();
                Console.WriteLine("Введите новую дату выполнения задачи (формат: dd.MM.yyyy):");
                string dateString = Console.ReadLine();
                DateTime date;
                if (DateTime.TryParse(dateString, out date))
                {
                    task.Date = date;
                }
                else
                {
                    Console.WriteLine("Некорректная дата");
                    return;
                }

                SaveTasks(tasks);
            }
            else
            {
                Console.WriteLine("Задачи с таким названием не найдена");
            }
        }

        // Показывает задачи на сегодня
        static void ShowTasksByDate(List<Task> tasks, DateTime date)
        {
            Console.WriteLine($"Задачи на {date.ToShortDateString()}:");
            foreach (Task task in tasks)
            {
                if (task.Date.Date == date.Date)
                {
                    Console.WriteLine($"{task.Name} - {task.Description}");
                }
            }
        }

        // Показывает все задачи
        static void ShowAllTasks(List<Task> tasks)
        {
            Console.WriteLine("Все задачи:");
            foreach (Task task in tasks)
            {
                Console.WriteLine($"{task.Name} - {task.Description} - {task.Date.ToShortDateString()}");
            }
        }

        // Показывает задачи, которые еще предстоит выполнить
        static void ShowTasksToDo(List<Task> tasks)
        {
            Console.WriteLine("Задачи, которые еще предстоит выполнить:");
            foreach (Task task in tasks)
            {
                if (task.Date > DateTime.Today)
                {
                    Console.WriteLine($"{task.Name} - {task.Description} - {task.Date.ToShortDateString()}");
                }
            }
        }

        // Показывает задачи, которые уже были выполнены
        static void ShowTasksDone(List<Task> tasks)
        {
            Console.WriteLine("Задачи, которые уже были выполнены:");
            foreach (Task task in tasks)
            {
                if (task.Date < DateTime.Today)
                {
                    Console.WriteLine($"{task.Name} - {task.Description} - {task.Date.ToShortDateString()}");
                }
            }
        }

        // Сохраняет список задач в файл JSON
        static void SaveTasks(List<Task> tasks)
        {
            string json = JsonSerializer.Serialize(tasks);
            File.WriteAllText(@"C:\Users\gr624_hasal\RiderProjects\ConsoleApp3\ConsoleApp17\tasks.json", json);
        }
    }

    // Класс задачи
    class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}