using System;
using System.IO;

public class Monitor
{
    private readonly string _path;
    private readonly FileSystemWatcher _watcher;

    public Monitor(string path)
    {
        _path = path;

        _watcher = new FileSystemWatcher(_path)
        {
            NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite | NotifyFilters.Size
        };

        _watcher.Created += (s, e) => EventLogger.Log("Created", e.FullPath);
        _watcher.Changed += (s, e) => EventLogger.Log("Changed", e.FullPath);
        _watcher.Deleted += (s, e) => EventLogger.Log("Deleted", e.FullPath);
        _watcher.Renamed += (s, e) =>
            EventLogger.Log("Renamed", $"{((RenamedEventArgs)e).OldFullPath} → {e.FullPath}");
    }

    public void Start()
    {
        _watcher.EnableRaisingEvents = true;
        Console.WriteLine($"Monitoring started on: {_path}");
    }
}
