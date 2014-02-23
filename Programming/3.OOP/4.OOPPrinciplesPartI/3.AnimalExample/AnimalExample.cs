namespace _3.AnimalExample
{
    using System;
    using System.Linq;

    class AnimalExample
    {
        static void Main()
        {
            var animals = new Animal[]
            {
                new Dog("Sharo", 5, Sex.Male),
                new Dog("Sara", 2, Sex.Female),
                new Frog("Rodger", 1, Sex.Male),
                new Frog("Kermit", 3, Sex.Male),
                new Frog("Edgar", 5, Sex.Male),
                new Frog("Elder Frog", 7, Sex.Male),
                new Kitten("Cherry", 1),
                new Tomcat("Silvester", 7),
                new Tomcat("Max", 9),
                new Tomcat("Kircho", 8),
            };

            foreach (var animal in animals)
            {
                //Console.WriteLine();
                //Console.WriteLine(animal.ToString());
                animal.ProduceSound();
            }
            Console.WriteLine();

            //calculate the average age of each kind of animal using a static 
            //method (you may use LINQ).

            //for dogs
            var dogs = animals.Where(an => an.GetType() == typeof(Dog));
            //foreach (var dog in dogs)
            //{
            //    dog.ProduceSound();
            //}
            double dogsAverageAge = dogs.Average(dog => dog.Age);
            Console.WriteLine("Average age for dogs is : {0}", dogsAverageAge);

            //for frogs
            var frogs = animals.Where(an => an.GetType() == typeof(Frog));
            //foreach (var frog in frogs)
            //{
            //    frog.ProduceSound();
            //}
            double frogsAverageAge = frogs.Average(frog => frog.Age);
            Console.WriteLine("Average age for frogs is : {0}", frogsAverageAge);

            //for cats
            var cats = animals.Where(an => an.GetType() == typeof(Kitten) || an.GetType() == typeof(Tomcat));
            //foreach (var cat in cats)
            //{
            //    cat.ProduceSound();
            //}
            double catsAverageAge = cats.Average(cat => cat.Age);
            Console.WriteLine("Average age for cats is : {0}", catsAverageAge);
        }
    }
}
