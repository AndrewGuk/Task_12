using Types;
using System;

namespace Task_12_Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            NewsProvider newsProvider = new NewsProvider();
            Client client = new Client();
            newsProvider.SubscribeTo(Category.News, client);
            newsProvider.AddNews(Category.News, "This is new news #1");
            newsProvider.SubscribeFrom(Category.News, client);
            newsProvider.AddNews(Category.News, "This is new news #2");
            Console.WriteLine("***** {0} *****", nameof(client));
            foreach (string str in client)
                Console.WriteLine("=> {0}", str);
            Console.WriteLine("******{0}*****", new string('*', nameof(client).Length));
            Console.ReadKey();
        }
    }
}