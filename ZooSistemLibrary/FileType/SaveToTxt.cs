using System.Collections.ObjectModel;
using System.IO;

namespace ZooSistemLibrary
{
    class SaveToTxt : ISaveZoo
    {
        public ObservableCollection<IAnimals> LoadFile(string path)
        {
            IsInputFile(path+".txt");
            throw new System.NotImplementedException();
        }

        public void SaveFile(string path, ObservableCollection<IAnimals> animals)
        {
            IsInputFile(path + ".txt");
        }
        private void IsInputFile(string path)
        {
            if (!File.Exists(path))
                using (StreamWriter sw = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write))) { };
        }
    }
}
