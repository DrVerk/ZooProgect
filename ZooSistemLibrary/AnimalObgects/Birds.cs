namespace ZooSistemLibrary
{
    class Birds : IAnimals
    {
        static int counter;
        static Birds()
        {
            counter = 0;
        }

        public Birds(string name, string age, string tipeOfAnimal)
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
