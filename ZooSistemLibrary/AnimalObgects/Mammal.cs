namespace ZooSistemLibrary
{
    class Mammal : IAnimals
    {
        static int counter;
        static Mammal()
        {
            counter = 0;
        }

        public Mammal(string name, string age, string tipeOfAnimal)
        {
            Name = name;
            Age = age;
            TipeOfAnimal = tipeOfAnimal;
            counter++;
        }

        public string Name { get; set; }
        public string Age { get; set; }
        public string TipeOfAnimal { get; set; }
        public override string ToString()
        {
            return $"{Name} {Age} {TipeOfAnimal}";
        }
    }
}
