namespace ZooSistemLibrary
{
    class Amphibians : IAnimals
    {
        static int counter;
        static Amphibians()
        {
            counter = 0;
        }

        public Amphibians(string name, string age, string tipeOfAnimal)
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
