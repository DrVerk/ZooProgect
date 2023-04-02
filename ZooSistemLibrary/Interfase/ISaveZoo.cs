using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ZooSistemLibrary
{
    internal interface ISaveZoo
    {
        IEnumerable<IAnimals>  LoadFile(string path);
        void SaveFile(string path, IEnumerable<IAnimals> animals);
    }
}