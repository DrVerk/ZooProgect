using System.Collections.Generic;
using System.Collections.ObjectModel;

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
    }
}
