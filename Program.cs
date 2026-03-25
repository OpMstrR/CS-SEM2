using System;

namespace ModulkTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            MessagePublisher publisher = new MessagePublisher();
            FileLogger logger = new FileLogger();

            publisher.OnMessageSent += logger.LogMessage;

            Console.WriteLine("Починаємо роботу. Введіть 4 повідомлення:");

            for (int i = 1; i <= 4; i++)
            {
                Console.Write($"Рядок {i}: ");
                string input = Console.ReadLine();

                publisher.Send(input);
            }

            Console.WriteLine("\nОбробка завершена. Перевір файл logPD21.txt");
            Console.ReadLine();
        }
    }
}

