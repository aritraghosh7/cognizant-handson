using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger1 = Logger.GetInstance();
            logger1.Log("This is the first log message.");

            var logger2 = Logger.GetInstance();
            logger2.Log("This is the second log message.");

            Console.WriteLine(
                object.ReferenceEquals(logger1, logger2)
                    ? "Both loggers are the same instance (Singleton works)."
                    : "Different logger instances (Singleton failed)."
            );
        }
    }
}
