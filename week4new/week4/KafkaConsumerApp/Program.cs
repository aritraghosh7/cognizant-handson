using System;
using System.Threading;
using Confluent.Kafka;

class Program
{
    public static void Main(string[] args)
    {
        var config = new ConsumerConfig
        {
            BootstrapServers = "localhost:9092",
            GroupId = "chat-group",
            AutoOffsetReset = AutoOffsetReset.Earliest
        };

        using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
        consumer.Subscribe("chat-topic");

        Console.WriteLine("Consuming messages from Kafka (Ctrl+C to exit):");

        try
        {
            while (true)
            {
                var cr = consumer.Consume(CancellationToken.None);
                Console.WriteLine($"Consumed message: {cr.Message.Value}");
            }
        }
        catch (OperationCanceledException)
        {
            consumer.Close();
        }
    }
}
