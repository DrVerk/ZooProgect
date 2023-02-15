namespace ZooSistemLibrary
{
    class AnimalsFactory
    {
        public IAnimals AnimalsCreate(string animtipe,
            string name,
            string age,
            string tipeofanimal)
        {
            switch (animtipe)
            {
                case "birds": return new Birds(name, age, tipeofanimal);
                case "mammal": return new Mammal(name, age, tipeofanimal);
                case "amphibians": return new Amphibians(name, age, tipeofanimal);
                default: return new NullAnimalObject();
            }
        }
    }
}
