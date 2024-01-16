using System;


namespace TaskManager
{

    class Program
    {
        static List<string> tasks = new List<string>();
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello, This your TaskManager Menu: ");

            while (true)
            {
                try
                {
                    Console.WriteLine("\n1. Add a new task\n2. show tasks list\n3. Mark your tasks done\n4. Delete a task");
                    Console.Write("ENTER: ");
                    int x = Convert.ToInt32(Console.ReadLine());


                    switch (x)
                    {
                        case 1:
                            newTask();
                            break;
                        case 2:
                            tasksList();
                            break;
                        case 3:
                            markTask();
                            break;
                        case 4:
                            deleteTask();
                            break;
                        default:
                            Console.WriteLine("Invalid Number!");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid Input!");
                }
            }
        }
        static void newTask()
        {
            Console.Write("Enter your new Task: ");
            string newNote = Console.ReadLine();
            tasks.Add(newNote);
            Console.WriteLine("Task created successfully!");
        }
        static void tasksList()
        {
            Console.WriteLine("Your Tasks list:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i}. {tasks[i]}");
            }
        }
        static void markTask()
        {
            Console.WriteLine("Which task do you want to mark DONE? :");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i}. {tasks[i]}");
            }
            Console.Write("ENTER: ");
            try
            {
                int y = 0;
                y = Convert.ToInt32(Console.ReadLine());
                if (y >= 0 || y <= tasks.Count)
                {
                    tasks[y] = $"{tasks[y]} ✓";
                    Console.WriteLine($"{y}. {tasks[y]}");
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }
            catch
            {
                Console.WriteLine("Invalid Input!");
            }
        }
        static void deleteTask()
        {
            Console.WriteLine("Which task do you want to DELETE? :");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i}. {tasks[i]}");
            }
            Console.WriteLine("ENTER: ");
            try
            {
                int y = Convert.ToInt32(Console.ReadLine());
                if (y! < 0 || y! > tasks.Count)
                {
                    tasks.Remove(tasks[y]);
                    Console.WriteLine($"{y}. {tasks[y]} was DELETED!");
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }
            catch
            {
                Console.WriteLine("Invalid Input!");
            }
        }
    }
}
