namespace _3.AnimalExample
{
    using System;

    public class Dog : Animal, ISound
    {
        public Dog(string name, int age, Sex sex)
            : base(name, age, sex)
        { }

        public override void ProduceSound()
        {
            Console.WriteLine(Name + ": I`m a dog! Baw Baw! Oh look a chinese restaurant!");
        }
    }
}
