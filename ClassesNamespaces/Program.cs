using ClassesNamespaces.Pets;
using System;

namespace ClassesNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //namespaces - a way of organizing code

            var dog1 = new Dog();

            dog1.FurType = "short";
            dog1.Name = "Fido";
            dog1.Breed = "pitbull";
            dog1.Weight = 74.5;

            Console.WriteLine($"{dog1.Name} is a {dog1.Breed} with {dog1.FurType} fur and weighs {dog1.Weight}");

            Dog dog2 = new Dog();
            dog2.FurType = "long";
            dog2.Name = "Astro";
            dog2.Breed = "Husky";
            dog2.Weight = 1.2;

            dog2.Bark();
            dog1.Bark();
            dog1.DateOfBirth = DateTime.Now.AddDays(-1000);
            Console.WriteLine($"{dog1.Name} is {dog1.Age} years old.");

        }
    }
}
