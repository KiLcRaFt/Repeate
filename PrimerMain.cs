using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Repeate.Primer;

namespace Repeate
{
    internal class PrimerMain
    {
        public class Program
        {
            public static void Main()
            {
                Random rnd = new Random();
                List<Message> mes = new List<Message>();

                //Message m1 = new Message("Hello", "John", DateTime.Now.AddDays(-10));
                //m1.AddLike();
                //m1.ShowInfo(m1);

                Message m2 = new Message("Hi", "Mary", DateTime.Now.AddMinutes(-1));
                m2.AddLike();
                m2.ShowInfo(m2);

                Message m3 = new Message("Bleb", "Methew", DateTime.Now.AddMinutes(-120));
                m3.AddLike();
                m3.ShowInfo(m3);

                //mes.Add(m1);
                //mes.Add(m2);
                //mes.Add(m3);

                for (int n = 1; n < rnd.Next(3, 10); n++)
                {
                    string names = string.Format("m{0}", n);
                    string x = Convert.ToString(names);
                    Console.WriteLine("Your name: ");
                    string authorn = Console.ReadLine();
                    Console.WriteLine("Your message: ");
                    string messages = Console.ReadLine();

                    Message m1 = new Message(messages, authorn, DateTime.Now);
                    m1.AddLike();
                    m1.ShowInfo(m1);
                };

                Console.WriteLine(m2.Popularity(m2.GetPopularity(), m2.GetPopularity()));
                Console.WriteLine(m2.PopularityN(mes));

            }
        }
    }
}
