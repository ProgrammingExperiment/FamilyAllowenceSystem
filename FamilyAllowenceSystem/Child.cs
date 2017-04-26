using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyAllowenceSystem
{
     class Child
    {
        String gender;
        String name;
        
        public string getName()
        {
            return name;
        }
        
        public Child(String Gender, String Name) {
            gender = Gender;
            name = Name;
        }
    }
}
