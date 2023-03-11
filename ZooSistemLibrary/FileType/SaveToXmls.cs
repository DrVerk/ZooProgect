using System.Collections.ObjectModel;
using System.IO;

namespace ZooSistemLibrary
{
    class SaveToXmls : ISaveZoo
    {
        public ObservableCollection<IAnimals> LoadFile(string path)
        {
            IsInputFile(path + ".xmls");
            throw new System.NotImplementedException();
        }

        public void SaveFile(string path, ObservableCollection<IAnimals> animals)
        {
            IsInputFile(path + ".xmls");
        }
        private void IsInputFile(string path)
        {
            if (!File.Exists(path))
                using (StreamWriter sw = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write))) { };
        }
    }
}
