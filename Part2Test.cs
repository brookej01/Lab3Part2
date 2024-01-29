using ConsoleApp2;
using Lab3Part2;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter dog's name: ");
        string dogName2 = Console.ReadLine();
        Console.Write("Enter dog's height: ");
        int dogHeight = int.Parse(Console.ReadLine());
        DogPart2 dog = new DogPart2();
        dog.Name = dogName2;
        dog.Colour = "Black";
        dog.Height = dogHeight;
        dog.Age = 4;
        Console.WriteLine($"Dog's Name: {dog.Name}");
        Console.WriteLine($"Dog's Colour: {dog.Colour}");
        Console.WriteLine($"Dog's Height: {dog.Height}");
        Console.WriteLine($"Dog's Age: {dog.Age}");
        dog.Eat();
        Console.WriteLine($"Dog says: {dog.Cry()}");

        Console.Write("Enter cat's name: ");
        string catName2 = Console.ReadLine();
        Console.Write("Enter cat's height: ");
        int catHeight = int.Parse(Console.ReadLine());
        CatPart2 cat = new CatPart2();
        cat.Name = catName2;
        cat.Colour = "Gray";
        cat.Height = catHeight;
        cat.Age = 5;
        Console.WriteLine($"Cat's Name: {cat.Name}");
        Console.WriteLine($"Cat's Colour: {cat.Colour}");
        Console.WriteLine($"Cat's Height: {cat.Height}");
        Console.WriteLine($"Cat's Age: {cat.Age}");
        cat.Eat();
        Console.WriteLine($"Cat says: {cat.Cry()}");

        // Part 2, step 6 & 7
        Console.WriteLine("\nCreating a list of animals and printing their names:");
        List<IAnimal> animals = new List<IAnimal>();
        animals.Add(dog);
        animals.Add(cat);
        foreach (var animal in animals)
        {
            Console.WriteLine(animal.Name);
        }
    }
}

