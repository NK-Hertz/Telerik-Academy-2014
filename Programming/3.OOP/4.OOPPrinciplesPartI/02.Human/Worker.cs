namespace _02.Human
{
    using System;
    using System.Collections.Generic;

    public class Worker : Human
    {
        private readonly int workingDays = 5;
        private int weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, int weekSalary, int workHoursPD)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPD;
        }

        public int WeekSalary 
        {
            get { return this.weekSalary; }
            private set { this.weekSalary = value; } 
        }

        public int WorkHoursPerDay 
        {
            get { return this.workHoursPerDay; }
            private set { this.workHoursPerDay = value; }
        }

        public decimal MoneyPerHour()
        {
            return (decimal)WeekSalary / (WorkHoursPerDay * workingDays);
        }

        //sorry for the bad output
        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " " + this.WeekSalary + " " +  this.WorkHoursPerDay;
            //return this.FirstName + " " + this.LastName + " " + this.WeekSalary + " " +  this.WorkHoursPerDay + " " + this.MoneyPerHour();
        }
    }
}
