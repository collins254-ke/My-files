using System;
using System.Collections.Generic;

class QueueProgram
{
    // Create a queue of integers
    static Queue<int> queue = new Queue<int>();

    // Method to enqueue (add) element
    static void EnqueueElement()
    {
        Console.Write("Enter value: ");
        int value;
        if (int.TryParse(Console.ReadLine(), out value))
        {
            queue.Enqueue(value);
            Console.WriteLine($"{value} enqueued.\n");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter an integer.\n");
        }
    }

    // Method to dequeue (remove) element
    static void DequeueElement()
    {
        if (queue.Count > 0)
        {
            int removedValue = queue.Dequeue();
            Console.WriteLine($"Dequeued element: {removedValue}\n");
        }
        else
        {
            Console.WriteLine("Queue is empty. Nothing to dequeue.\n");
        }
    }

    // Method to display queue elements
    static void DisplayQueue()
    {
        if (queue.Count > 0)
        {
            Console.Write("Queue elements: ");
            foreach (int item in queue)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
        }
        else
        {
            Console.WriteLine("Queue is empty.\n");
        }
    }

    // Main method
    static void Main()
    {
        int choice = 0;

        Console.WriteLine("Welcome To Queue Menu");

        do
        {
            Console.WriteLine("1. Enqueue");
            Console.WriteLine("2. Dequeue");
            Console.WriteLine("3. Display");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        EnqueueElement();
                        break;
                    case 2:
                        DequeueElement();
                        break;
                    case 3:
                        DisplayQueue();
                        break;
                    case 4:
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select between 1–4.\n");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.\n");
            }

        } while (choice != 4);
    }
}
