using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace ZooSistemLibrary
{
    class SaveToJson : ISaveZoo
    {
        public IEnumerable<IAnimals> LoadFile(string path)
        {
            IsInputFile(@"..\" + path + ".json");
            return JsonConvert.DeserializeObject<IEnumerable<IAnimals>>(File.ReadAllText(@"..\" + path + ".json"));
        }

        public void SaveFile(string path, IEnumerable<IAnimals> animals)
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
