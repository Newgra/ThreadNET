using System.Text;

Console.OutputEncoding = UTF8Encoding.UTF8;

TimerCallback callback = new TimerCallback(TimerBack);
Timer timer = new Timer(callback, null, 0, 1000);

Console.WriteLine("Головний потік: Запуск");
Thread.Sleep(10000);
timer.Dispose();
Console.WriteLine("Головний потік: Програма завершила роботу.");

void TimerBack(object state)
{
    Console.WriteLine($"Callback: Потік викликаний на {DateTime.Now}");
}




/*
1.Що таке багатонитковість?
2.Загальні відомості про потоки:
    1.що таке потік?
    2.породження потоків;
    3.призупинення, відновлення, припинення потоку;
    4.пріоритети потоків.
*/