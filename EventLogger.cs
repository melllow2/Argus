using System;
using System.IO;
using System.Text.Json;

public static class EventLogger
{
    public static void Log(string eventType, string filePath)
    {
        var log = new
        {
            Timestamp = DateTime.Now,
            Event = eventType,
            File = filePath
        };

        string json = JsonSerializer.Serialize(log);
        Console.WriteLine(json);
        File.AppendAllText("eventlog.json", json + Environment.NewLine);
    }
}
