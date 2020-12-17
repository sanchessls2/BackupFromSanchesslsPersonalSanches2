using System;
using System.IO;
public static class Log
{
    public static void Write(string line)
    {
        using (StreamWriter w = File.AppendText("log.txt"))
        {
            LogLine(line, w);
        }


    }

    public static void LogLine(string logMessage, TextWriter w)
    {
        
        w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");        
        w.WriteLine($"  :{logMessage}");
        w.WriteLine("-------------------------------");
    }
}