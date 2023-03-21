using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.IO;

namespace ZooSistemLibrary
{
    class SaveToJson : ISaveZoo
    {
        public ObservableCollection<IAnimals> LoadFile(string path)
        {
            IsInputFile(@"..\" + path + ".json");
            return JsonConvert.DeserializeObject<ObservableCollection<IAnimals>>(File.ReadAllText(@"..\" + path + ".json"));
        }

        public void SaveFile(string path, ObservableCollection<IAnimals> animals)
        {
            string str = JsonConvert.SerializeObject(animals);
            IsInputFile(@"..\" + path ?? "zoo" + ".json");
            File.WriteAllText(@"..\" + path + ".json", str);

        }
        private void IsInputFile(string path)
        {
            if (!File.Exists(path))
                using (StreamWriter sw = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write))) { };
        }
    }
}
