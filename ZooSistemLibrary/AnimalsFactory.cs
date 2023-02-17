namespace ZooSistemLibrary
{
    static class AnimalsFactory
    {
        public static IAnimals AnimalsCreate(string animtipe,
            string name,
            string age)
        {
            switch (animtipe)
            {
                case "birds": return new Birds(name, age);
                case "mammal": return new Mammal(name, age);
                case "amphibians": return new Amphibians(name, age);
                default: return new NullAnimalObject();
            }
        }
    }
}
