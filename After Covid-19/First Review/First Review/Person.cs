using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace First_Review
{
    class Person
    {

        
        string name;
        int age;
        double height;
        //variables
        //Name, Age, Height
        public Person(string name, int age, double height)
        {
            this.name = name;
            this.age = age;
            this.height = height;
        }

        //get and set functions
        //Get function gets the value
        //Set function sets the value

        //Set functions for age and height must only change the value if it is greater than 0

        public string GetName()
        {
            return name;

        }

        public int GetAge()
        {
            return age;

        }

        public double GetHeight()
        {
            return height;

        }


        public void SetName(string UserName)
        {
            name = UserName;
        }

        public void SetAge(int UserAge)
        {
            if (UserAge > 0)
            {
                age = UserAge; 
            }
        }

        public void SetHeight(double UserHeight)
        {
            
            if (UserHeight > 0)
            {
               height = UserHeight;
            }
        }
    }
}
