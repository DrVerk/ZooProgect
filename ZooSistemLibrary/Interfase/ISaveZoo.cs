using System.Collections.ObjectModel;

namespace ZooSistemLibrary
{
    internal interface ISaveZoo
    {
        ObservableCollection<IAnimals>  LoadFile(string path);
        void SaveFile(string path, ObservableCollection<IAnimals> animals);
    }
}