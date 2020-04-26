using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Xml;

namespace entity
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using (UserContext db=new UserContext())
            {
                var users = from u in db.Users orderby u.Age ascending select u;// по возрасту выводим(сначала-младшие)
                var ageSel = db.Users.Max(u => u.Age);
                foreach (var user in users)
                    Console.WriteLine($"{user.Id}-{user.Name}-{user.Age}");
                Console.WriteLine("====================");
                Console.WriteLine(ageSel);

            }
        }
    }
}