using System;

namespace Methods
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public PersonalInfo PersonalInformation { get; set; }

        public bool IsOlderThan(Student other)
        {
            bool isOlder = false;
            DateTime firstDate = this.PersonalInformation.BirthDate;
            DateTime secondDate = other.PersonalInformation.BirthDate;
            if (DateTime.Compare(firstDate,secondDate) < 0)
            {
                isOlder = true;
            }

            return isOlder;
        }
    }

    public class PersonalInfo 
    {
        public string City { get; set; }
        public DateTime BirthDate { get; set; }
        public string Hobby { get; set; }

        public PersonalInfo(string city, string birthDate)
        {
            this.City = city;
            this.BirthDate = DateTime.Parse(birthDate);
        }

        public PersonalInfo(string city, string birthDate, string hobby) :
            this(city, birthDate)
        {
            this.Hobby = hobby;
        }

    }
}
