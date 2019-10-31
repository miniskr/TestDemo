using System;
using System.Threading.Tasks;

namespace QueueDemo
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            var dm = new DocumentManager();
            Task processDocuments = ProcessDocuments.Start(dm);

            // Create documents and add them to the DocumentManager
            for(var i = 0; i < 1000; ++i)
            {
                var doc = new Document($"Doc {i.ToString()}", "conetnt");
                dm.AddDocument(doc);
                Console.WriteLine($"Added document {doc.Title}");
                await Task.Delay(new Random().Next(20));
            }
            await processDocuments;
            Console.ReadLine();
        }
    }
}
