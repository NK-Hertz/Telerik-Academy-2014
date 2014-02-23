namespace _3.AnimalExample
{
    using System;
    
    public enum Sex { Male, Female} ;

    public abstract class Animal : ISound
    {
        private int age;
        private string name;
        private readonly Sex sex;

        protected Animal(string name, int age, Sex sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public Sex Sex
        {
            get { return sex; }
        }

        public abstract void ProduceSound();

        //public static double AverageAge(Animal[] animals)
        //{
        //    return 0;  
        //}

        public override string ToString()
        {
            string info = string.Format("Type: {0}\nName: {1}\nAge: {2}\nSex: {3}"
                , this.GetType(), this.Name, this.Age, this.Sex);

            return info;
        }
    }
}
