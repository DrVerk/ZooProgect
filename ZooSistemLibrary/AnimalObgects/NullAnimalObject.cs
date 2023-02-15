namespace ZooSistemLibrary
{
    class NullAnimalObject : IAnimals
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

        public string Name { get; set; }
        public string Age { get; set; }
        public string TipeOfAnimal { get; set; }
        public override string ToString()
        {
            return $"{Name} {Age} {TipeOfAnimal}";
        }
    }
}
