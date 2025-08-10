using System;
using System.Threading.Tasks;
using Confluent.Kafka;

class Program
{
    public static async Task Main(string[] args)
    {
        var config = new ProducerConfig { BootstrapServers = "localhost:9092" };

        using var producer = new ProducerBuilder<Null, string>(config).Build();

        Console.WriteLine("Enter messages to send to Kafka (type 'exit' to quit):");
        string input;
        while ((input = Console.ReadLine()) != "exit")
        {
            var dr = await producer.ProduceAsync("chat-topic", new Message<Null, string> { Value = input });
            Console.WriteLine($"Delivered '{dr.Value}' to '{dr.TopicPartitionOffset}'");
        }
    }
}
