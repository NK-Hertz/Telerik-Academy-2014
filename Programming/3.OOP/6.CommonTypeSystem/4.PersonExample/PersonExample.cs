using System;
/*
 * 4.Create a class Person with two fields – name and age. Age can be left unspecified 
 * (may contain null value. Override ToString() to display the information of a person 
 * and if age is not specified – to say so. Write a program to test this functionality.
 */

class PersonExample
{
    static void Main()
    {
        Person Ivan = new Person("Ivan");
        Person Pesho = new Person("Pesho", null);
        Person Gosho = new Person("Gosho", 22);

        Console.WriteLine(Ivan);
        Console.WriteLine(Pesho);
        Console.WriteLine(Gosho);

    }
}