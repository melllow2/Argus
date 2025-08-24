using System;

class Program
{
    static void Main()
    {
        string path = @"C:\Users\III\Desktop\ArgusFileMonitor\WatchedFolder";

        var monitor = new Monitor(path);
        monitor.Start();

        Console.WriteLine("Press Enter to exit.");
        Console.ReadLine();
    }
}
