using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Repeate
{
    internal class Primer
    {
        public class Message
        {
            private readonly string _content;
            private readonly string _author;
            private readonly DateTime _time;
            private int _likes;

            public Message(string content, string author, DateTime time)
            {
                _content = content;
                _author = author;
                _time = time;
            }

            public int Likes { get => _likes; }
            public DateTime Time { get => _time; }
            public string Author { get => _author; }
            public string Content { get => _content; }

            public void AddLike()
            {
                Random rnd = new Random();
                _likes += rnd.Next(1, 5);
            }

            public double GetPopularity()
            {
                double elapsed = DateTime.Now.Subtract(_time).TotalSeconds;
                if (elapsed == 0)
                {
                    return _likes;
                }
                return _likes / elapsed;

            }
            public void ShowInfo(Message x)
            {
                
                Console.WriteLine("Message: " + x.Content);
                Console.WriteLine("Author: " + x.Author);
                Console.WriteLine("Time: " + x.Time);
                Console.WriteLine("Baltika " + x.GetPopularity());
                Console.WriteLine();
            }

            public string Popularity(double _x, double _y)
            {
                string ans = "";
                if (_x > _y)
                {
                    ans = "Esimene sõnum is populaase";
                }

                else
                {
                    ans = "Teine sõnum is populaase";
                }
                return ans;
            }

            public string PopularityN(List<Message> mes)
            {
                string ans = "";
                double popularity = 0;
                for (int i = 0; i < mes.Count; i++) 
                { 
                    if (mes[i].GetPopularity()>=popularity)
                    {
                        ans = mes[i].Content;
                    }
                }
                return ans;
            }
        }
    }
}
