using System.Collections;

namespace Types
{
    public class NewsProvider
    {
        private delegate void MethodAddTo(string msg);
        private event MethodAddTo ClientNews;
        private event MethodAddTo ClientWeather;
        private event MethodAddTo ClientSport;
        private event MethodAddTo ClientEvents;
        private event MethodAddTo ClientHumor;

        public void SubscribeTo(Category id, Client item)
        {
            switch (id)
            {
                case Category.News:
                    ClientNews += item.AddNews;
                    break;
                case Category.Weather:
                    ClientWeather += item.AddNews;
                    break;
                case Category.Sport:
                    ClientSport += item.AddNews;
                    break;
                case Category.Events:
                    ClientEvents += item.AddNews;
                    break;
                case Category.Humor:
                    ClientHumor += item.AddNews;
                    break;
                default:
                    break;
            }
        }
        public void SubscribeFrom(Category id, Client item)
        {
            switch (id)
            {
                case Category.News:
                    ClientNews -= item.AddNews;
                    break;
                case Category.Weather:
                    ClientWeather -= item.AddNews;
                    break;
                case Category.Sport:
                    ClientSport -= item.AddNews;
                    break;
                case Category.Events:
                    ClientEvents -= item.AddNews;
                    break;
                case Category.Humor:
                    ClientHumor -= item.AddNews;
                    break;
                default:
                    break;
            }
        }
        public void AddNews(Category id, string msg)
        {
            switch (id)
            {
                case Category.News:
                    if (ClientNews != null)
                        ClientNews(msg);
                    break;
                case Category.Weather:
                    if (ClientWeather != null)
                        ClientWeather(msg);
                    break;
                case Category.Sport:
                    if (ClientSport != null)
                        ClientSport(msg);
                    break;
                case Category.Events:
                    if (ClientEvents != null)
                        ClientEvents(msg);
                    break;
                case Category.Humor:
                    if (ClientHumor != null)
                        ClientHumor(msg);
                    break;
                default:
                    break;
            }
        }
    }
    public class Client : IEnumerable
    {
        private System.Collections.Specialized.StringCollection Data;

        public Client()
        {
            Data = new System.Collections.Specialized.StringCollection();
        }
        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)Data).GetEnumerator();
        }
        public void AddNews(string msg)
        {
            Data.Add(msg);
        }
    }
}