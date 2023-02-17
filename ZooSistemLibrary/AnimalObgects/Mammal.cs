using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ZooSistemLibrary
{
    class Mammal : IAnimals
    {
        static int counter;
        static Mammal()
        {
            counter = 0;
        }

        public Mammal(string name, string age)
        {
            Name = name;
            Age = age;
            TipeOfAnimal = "млекопитающее";
            counter++;
        }

        string _name, _age, _tipeofanimal;
        public string Name { get => _name; set { _name = value; } }
        public string Age { get => _age; set { _age = value; } }
        public string TipeOfAnimal { get => _tipeofanimal; set { _tipeofanimal = value; } }

        public override string ToString()
        {
            return $"{Name} {Age} {TipeOfAnimal}";
        }
    }
}
