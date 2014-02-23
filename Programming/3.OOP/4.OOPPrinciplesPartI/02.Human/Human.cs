namespace _02.Human
{
    using System;
    using System.Collections.Generic;

    public abstract class Human
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

    }
}
