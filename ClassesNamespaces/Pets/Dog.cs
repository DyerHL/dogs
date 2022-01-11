using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesNamespaces.Pets
{
    //class - a custom type (Dog is a custom type) - classes get title case
    public class Dog
    {   //properties (auto property- has a plain getter/setter) (calculated property - )
        //access modifier (ex. public, private) Public means that this property can be accessed outstide of this class, Structure: type  name  getter & setter
        public string FurType { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public double Weight { get; set; }
        public DateTime DateOfBirth { get; set; } //can have private setter
        //calculated property
        public int Age
        {
            get
            {
                return (DateTime.Now - DateOfBirth).Days / 365;
            }
        }


        //methods  - TitleCase, talks about the behaviors of a class
        //access modifier  Structure: return type  name  code
        public void Bark()
        {
            Console.WriteLine($"{Name} barks loudly.");
        }

    }
}
