using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace ZooSistemLibrary
{
    public class Model
    {
        public ObservableCollection<IAnimals> Animals { get; set; }
        public Model()
        {
            Animals = new ObservableCollection<IAnimals>();
        }
        public void AddNewAnimals()
        {
            Animals.Add(AnimalsFactory.AnimalsCreate("", "", ""));
        }
        public void AddNewAnimals(string animtipe,
            string name,
            string age)
        {
            Animals.Add(AnimalsFactory.AnimalsCreate(animtipe, name, age));
        }

        public void RemuveAnimal(IAnimals animals)
        {
            Animals.Remove(animals);
        }

    }

}
