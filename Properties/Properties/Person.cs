using System;

namespace Properties
{
    public class Person
    {
        public String Name{ get; set; } //Auto implemented property. 
        public string Username{ get; set; }
        public DateTime Birthdate { get; private set; } // the 'private set' accessor means it's readonly. Which means 'birthdate' cannot be changed

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }
    }
}
