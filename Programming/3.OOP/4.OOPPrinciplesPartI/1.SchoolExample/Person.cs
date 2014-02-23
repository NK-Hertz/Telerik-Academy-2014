namespace _1.SchoolExample
{
    using System;

    public abstract class Person : IComment
    {
        private string name;
        private string comment;

        protected Person(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            private set 
            {
                if (value.Length <= 2)
                {
                    throw new ArgumentException("Name must be bigger than 2 symbols!");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public void AddComment(string comment)
        {
            if (string.IsNullOrEmpty(comment))
            {
                throw new ArgumentNullException("This is not a valid comment!It should not be a empty or null!");
            }
            else
            {
                this.comment = comment;
            }
        }

        public void GetComment()
        {
            Console.WriteLine(this.comment);
        }

    }
}
