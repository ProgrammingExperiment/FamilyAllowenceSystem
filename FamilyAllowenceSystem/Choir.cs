using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyAllowenceSystem
{

    enum ChoirName { Vacuum, FeedBunnies, TakeOutTrash, WashDishes }

    class Choir
    {
        //Attributes
        ChoirName choir;
        double Amount;

        public ChoirName getChoir()
        {
            return choir;
        }

        //Methods
        public double getAmount()
        {
            return Amount;
        }
        //Constructor
        public Choir(ChoirName c )
        {
            choir = c;

            if (ChoirName.Vacuum == c)
            {
                 Amount = 10.00;
            }else if(c == ChoirName.FeedBunnies)
            { 
                Amount = 10.00;
            }else if (c == ChoirName.TakeOutTrash)
            {
                 Amount = 5.0;
            }else if (c == ChoirName.WashDishes)
            {
                Amount = 25.0;
            }
           

         }
    }
    
}
