using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace EnumsAndSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Todo> todos = new List<Todo>()
            {
                new Todo {Description = "Task 1", EstimatedHours = 3, Estado = Estado.Completed},
                new Todo {Description = "Task 2", EstimatedHours = 2, Estado = Estado.InProgress},
                new Todo {Description = "Task 3", EstimatedHours = 5, Estado = Estado.NotStarted},
                new Todo {Description = "Task 4", EstimatedHours = 1, Estado = Estado.Deleted},
                new Todo {Description = "Task 5", EstimatedHours = 8, Estado = Estado.Completed},
                new Todo {Description = "Task 6", EstimatedHours = 4, Estado = Estado.InProgress},
                new Todo {Description = "Task 7", EstimatedHours = 3, Estado = Estado.OnHold},
                new Todo {Description = "Task 8", EstimatedHours = 5, Estado = Estado.InProgress},
                new Todo {Description = "Task 9", EstimatedHours = 6, Estado = Estado.NotStarted},
                new Todo {Description = "Task 10", EstimatedHours = 7, Estado = Estado.InProgress},
                new Todo {Description = "Task 11", EstimatedHours = 1, Estado = Estado.Deleted},
                new Todo {Description = "Task 12", EstimatedHours = 5, Estado = Estado.Completed},
                new Todo {Description = "Task 13", EstimatedHours = 4, Estado = Estado.InProgress}
            };

            PrintAssesment(todos);
            Console.ReadLine();
        }

        private static void PrintAssesment(List<Todo>todos)
        {
            foreach (var todo in todos)
            {
                switch (todo.Estado)
                {
                    case Estado.Completed:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Estado.InProgress:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case Estado.NotStarted:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    case Estado.Deleted:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Estado.OnHold:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        break;
                    default:
                        break;
                }
                Console.WriteLine(todo.Description);
            }
        }                
    }

    class Todo
    {
        public string? Description { get; set; }
        public int EstimatedHours { get; set; }
        public Estado Estado { get; set; }
    }

    enum Estado
    {
        Completed,
        InProgress,
        OnHold,
        NotStarted,
        Deleted
    }
}