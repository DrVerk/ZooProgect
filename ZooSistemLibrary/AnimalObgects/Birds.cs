using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ZooSistemLibrary
{
    class Birds : IAnimals
    {
        static int counter;
        static Birds()
        {
            counter = 0;
        }

        public Birds(string name, string age)
        {
            Name = name;
            Age = age;
            TipeOfAnimal = "Птица";
            counter++;
        }
        string _name, _age, _tipeofanimal;
        public string Name { get => _name; set { _name = value; } }
        public string Age { get => _age; set { _age = value;  } }
        public string TipeOfAnimal { get => _tipeofanimal; set { _tipeofanimal = value; } }

        public override string ToString()
        {
            return $"{Name} {Age} {TipeOfAnimal}";
        }
    }
}
