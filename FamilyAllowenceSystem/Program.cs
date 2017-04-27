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
            var Daughter1 = new Child("Daughter", "Sophia");
            var Daughter2 = new Child("Daughter", "Emilia");


            Dictionary<Child, List<Choir>> week1 = new Dictionary<Child, List<Choir>>();
            Dictionary<Child, List<Choir>> week2 = new Dictionary<Child, List<Choir>>();

            List<Choir> Son1ChoirsDone = new List<Choir>();
            List<Choir> Son2ChoirsDone = new List<Choir>();
            List<Choir> Daughter1ChoirDone = new List<Choir>();
            List<Choir> Daughter2ChoirDone = new List<Choir>();

            Console.WriteLine("Week one");
            Son1ChoirsDone.Add(new Choir(ChoirName.TakeOutTrash));
            Son1ChoirsDone.Add(new Choir(ChoirName.TakeOutTrash));

            week1.Add(Son1, Son1ChoirsDone);
            // Son2 week1 choirs
            Son2ChoirsDone.Add(new Choir(ChoirName.FeedBunnies));
            Son2ChoirsDone.Add(new Choir(ChoirName.FeedBunnies));
            Son2ChoirsDone.Add(new Choir(ChoirName.FeedBunnies));
            Son2ChoirsDone.Add(new Choir(ChoirName.FeedBunnies));
            Son2ChoirsDone.Add(new Choir(ChoirName.FeedBunnies));
            Son2ChoirsDone.Add(new Choir(ChoirName.FeedBunnies));
            Son2ChoirsDone.Add(new Choir(ChoirName.FeedBunnies));

            week1.Add(Son2, Son2ChoirsDone);
;
            Daughter1ChoirDone.Add(new Choir(ChoirName.FeedBunnies));
            Daughter1ChoirDone.Add(new Choir(ChoirName.FeedBunnies));
            Daughter1ChoirDone.Add(new Choir(ChoirName.FeedBunnies));
            Daughter1ChoirDone.Add(new Choir(ChoirName.FeedBunnies));
            Daughter1ChoirDone.Add(new Choir(ChoirName.FeedBunnies));
            Daughter1ChoirDone.Add(new Choir(ChoirName.FeedBunnies));
            Daughter1ChoirDone.Add(new Choir(ChoirName.FeedBunnies));

            week1.Add(Daughter1, Daughter1ChoirDone);

            Daughter2ChoirDone.Add(new Choir(ChoirName.Vacuum));
            Daughter2ChoirDone.Add(new Choir(ChoirName.Vacuum));
            Daughter2ChoirDone.Add(new Choir(ChoirName.Vacuum));
            Daughter2ChoirDone.Add(new Choir(ChoirName.Vacuum));
            Daughter2ChoirDone.Add(new Choir(ChoirName.Vacuum));
            Daughter2ChoirDone.Add(new Choir(ChoirName.Vacuum));
            Daughter2ChoirDone.Add(new Choir(ChoirName.Vacuum));

            week1.Add(Daughter2, Daughter2ChoirDone);


            foreach (KeyValuePair<Child, List<Choir>> pair in week1)
            {
                var theList = pair.Value;
                var total = 0.00;
                foreach (var item in theList)
                {
                    total = total + item.getAmount();  
                }
                Console.WriteLine("Child: " + pair.Key.getName() + " total amount of allowence for week1: " + total.ToString());
                Console.WriteLine("");
            }

            Son1ChoirsDone.Clear();
            Son2ChoirsDone.Clear();
            Daughter1ChoirDone.Clear();
            Daughter2ChoirDone.Clear();

            Console.WriteLine("Week Two");

            Son1ChoirsDone.Add(new Choir(ChoirName.TakeOutTrash));
            Son1ChoirsDone.Add(new Choir(ChoirName.TakeOutTrash));
            Son1ChoirsDone.Add(new Choir(ChoirName.TakeOutTrash));
            Son1ChoirsDone.Add(new Choir(ChoirName.TakeOutTrash));
            Son1ChoirsDone.Add(new Choir(ChoirName.TakeOutTrash));

            week2.Add(Son1, Son1ChoirsDone);

            Son2ChoirsDone.Add(new Choir(ChoirName.FeedBunnies));
            Son2ChoirsDone.Add(new Choir(ChoirName.FeedBunnies));
            Son2ChoirsDone.Add(new Choir(ChoirName.FeedBunnies));
            Son2ChoirsDone.Add(new Choir(ChoirName.FeedBunnies));
            Son2ChoirsDone.Add(new Choir(ChoirName.FeedBunnies));
            Son2ChoirsDone.Add(new Choir(ChoirName.FeedBunnies));
            Son2ChoirsDone.Add(new Choir(ChoirName.FeedBunnies));

            week2.Add(Son2, Son2ChoirsDone);

            Daughter1ChoirDone.Add(new Choir(ChoirName.FeedBunnies));
            Daughter1ChoirDone.Add(new Choir(ChoirName.FeedBunnies));
            Daughter1ChoirDone.Add(new Choir(ChoirName.FeedBunnies));
            Daughter1ChoirDone.Add(new Choir(ChoirName.FeedBunnies));
            Daughter1ChoirDone.Add(new Choir(ChoirName.FeedBunnies));
            Daughter1ChoirDone.Add(new Choir(ChoirName.FeedBunnies));
            Daughter1ChoirDone.Add(new Choir(ChoirName.FeedBunnies));

            week2.Add(Daughter1, Daughter1ChoirDone);

            Daughter2ChoirDone.Add(new Choir(ChoirName.Vacuum));
            Daughter2ChoirDone.Add(new Choir(ChoirName.Vacuum));
            Daughter2ChoirDone.Add(new Choir(ChoirName.Vacuum));
            Daughter2ChoirDone.Add(new Choir(ChoirName.Vacuum));
            Daughter2ChoirDone.Add(new Choir(ChoirName.Vacuum));
            Daughter2ChoirDone.Add(new Choir(ChoirName.Vacuum));
            Daughter2ChoirDone.Add(new Choir(ChoirName.Vacuum));

            week2.Add(Daughter2, Daughter2ChoirDone);


            foreach (KeyValuePair<Child, List<Choir>> pair in week2)
            {
                var theList = pair.Value;
                var total = 0.00;
                foreach (var item in theList)
                {
                    total = total + item.getAmount();
                }
                Console.WriteLine("Child: " + pair.Key.getName() + " total amount of allowence for this week2: " + total.ToString());
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
