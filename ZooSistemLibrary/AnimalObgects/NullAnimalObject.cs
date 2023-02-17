using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ZooSistemLibrary
{
    public class NullAnimalObject : IAnimals
    {
        static int counter;

        static NullAnimalObject()
        {
            counter = 0;
        }

        public NullAnimalObject()
        {
            Name = "Имя не определено";
            Age = "Возраст не определён";
            TipeOfAnimal = "тип животного не определен";
            counter++;
        }
        string _name, _age, _tipeofanimal;
        public string Name { get => _name; set { _name = value;; } }
        public string Age { get => _age; set { _age = value;  } }
        public string TipeOfAnimal { get => _tipeofanimal; set { _tipeofanimal = value; } }

        public override string ToString()
        {
            return $"{Name} {Age} {TipeOfAnimal}";
        }
    }
}
