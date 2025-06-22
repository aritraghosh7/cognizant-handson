using System;

namespace SingletonPattern
{
    public class Logger
    {
        private static Logger? _instance; // Nullable fix
        private static readonly object _lock = new object();

        // Private constructor
        private Logger()
        {
            Console.WriteLine("Logger instance created");
        }

        public static Logger GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new Logger();
                }
            }
            return _instance;
        }

        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }
}
