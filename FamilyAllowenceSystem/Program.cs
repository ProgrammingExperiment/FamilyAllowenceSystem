using System;
using System.Collections.Generic;

namespace FamilyAllowenceSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var Dad = new Parent("Alfredo", "man");
            var Mom = new Parent("Jessica", "woman");
            var Son1 = new Child("son", "Lloyd");
            var Son2 = new Child("son", "Webber");

            Dictionary<Child, List<Choir>> week1 = new Dictionary<Child, List<Choir>>();
            Dictionary<Child, List<Choir>> week2 = new Dictionary<Child, List<Choir>>();

            List<Choir> Son1ChoirsDone = new List<Choir>();
            List<Choir> Son2ChoirsDone = new List<Choir>();

            Son1ChoirsDone.Add(new Choir(ChoirName.TakeOutTrash));
            Son1ChoirsDone.Add(new Choir(ChoirName.TakeOutTrash));
            week1.Add(Son1, Son1ChoirsDone);

            Son2ChoirsDone.Add(new Choir(ChoirName.FeedBunnies));
            Son2ChoirsDone.Add(new Choir(ChoirName.FeedBunnies));
            Son2ChoirsDone.Add(new Choir(ChoirName.FeedBunnies));
            Son2ChoirsDone.Add(new Choir(ChoirName.FeedBunnies));
            Son2ChoirsDone.Add(new Choir(ChoirName.FeedBunnies));
            Son2ChoirsDone.Add(new Choir(ChoirName.FeedBunnies));
            Son2ChoirsDone.Add(new Choir(ChoirName.FeedBunnies));

            week1.Add(Son2, Son2ChoirsDone);

            foreach (KeyValuePair<Child, List<Choir>> pair in week1)
            {
                var theList = pair.Value;
                var total = 0.00;
                foreach (var item in theList)
                {
                    total = total + item.getAmount();  
                }
                Console.WriteLine("Child: " + pair.Key.getName() + " total amount of allowence for week1: " + total.ToString());
                
            }

            Son1ChoirsDone.Clear();
            Son1ChoirsDone.Add(new Choir(ChoirName.TakeOutTrash));
            Son1ChoirsDone.Add(new Choir(ChoirName.TakeOutTrash));
            Son1ChoirsDone.Add(new Choir(ChoirName.TakeOutTrash));
            Son1ChoirsDone.Add(new Choir(ChoirName.TakeOutTrash));
            Son1ChoirsDone.Add(new Choir(ChoirName.TakeOutTrash));
            week2.Add(Son1, Son1ChoirsDone);

            foreach (KeyValuePair<Child, List<Choir>> pair in week2)
            {
                var theList = pair.Value;
                var total = 0.00;
                foreach (var item in theList)
                {
                    total = total + item.getAmount();
                }
                Console.WriteLine("Child: " + pair.Key.getName() + " total amount of allowence for this week2: " + total.ToString());

            }

            Console.ReadLine();
        }
    }
}
