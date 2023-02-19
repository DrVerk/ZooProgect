using System.Collections.ObjectModel;

namespace ZooSistemLibrary
{
    internal interface ISaveZoo
    {
        void LoadFile(string path, ref ObservableCollection<IAnimals> animals);
        void SaveFile(string path, ObservableCollection<IAnimals> animals);
    }
}