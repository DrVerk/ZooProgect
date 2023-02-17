using System.Collections.ObjectModel;

namespace ZooSistemLibrary
{
    class SaveToTxt : ISaveZoo
    {
        public SaveToTxt() { }

        public void LoadFile(string path, ref ObservableCollection<IAnimals> animals)
        {
            throw new System.NotImplementedException();
        }

        public void SaveFile(string path, ObservableCollection<IAnimals> animals)
        {
            throw new System.NotImplementedException();
        }
    }
}
