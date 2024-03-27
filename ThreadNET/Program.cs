using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             3.Потоки в .NET Core:
                1.простір System.Threading;
                2.клас Thread;
                3.потоки фонові і первинні;
                4.породження потоків;
                5.призупинення, відновлення, припинення потоку;
                6.пріоритети потоків.
             */
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Thread primaryThread = Thread.CurrentThread;
            Console.WriteLine($"Основний потік: ID - {primaryThread.ManagedThreadId}, Назва - {primaryThread.Name}, Пріоритет - {primaryThread.Priority}");

            // 3.потоки фонові і первинні;
            Thread backgroundThread = new Thread(BackgroundThreadMethod);
            backgroundThread.IsBackground = true;
            backgroundThread.Start();

            // 4.породження потоків;
            Thread newThread = new Thread(NewThreadMethod);
            newThread.Start();

            // 5.призупинення, відновлення та припинення потоку.
            Thread sleepThread = new Thread(SleepThreadMethod);
            sleepThread.Start();

            // 6.пріоритети потоків.
            Thread priorityThread = new Thread(PriorityThreadMethod);
            priorityThread.Priority = ThreadPriority.Highest;
            priorityThread.Start();

            Console.ReadLine();
        }

        static void BackgroundThreadMethod()
        {
            Console.WriteLine("Фоновий потік запущено.");
            Thread.Sleep(5000);
            Console.WriteLine("Фоновий потік завершено.");
        }

        static void NewThreadMethod()
        {
            Console.WriteLine("Новий потік запущено.");
            Thread.Sleep(3000);
            Console.WriteLine("Новий потік завершено.");
        }

        static void SleepThreadMethod()
        {
            Console.WriteLine("Потік для призупинення запущено.");
            Thread.Sleep(2000);
            Console.WriteLine("Потік для призупинення завершено.");
        }

        static void PriorityThreadMethod()
        {
            Console.WriteLine("Потік з високим пріоритетом запущено.");
            Thread.Sleep(4000);
            Console.WriteLine("Потік з високим пріоритетом завершено.");
        }
    }
}