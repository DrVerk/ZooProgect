using System.Collections.ObjectModel;

namespace ZooSistemLibrary
{
    static class SaveFileFactory
    {
        public static void SaveFile(string savetype, string puch, ObservableCollection<IAnimals> animals)
        {
            ISaveZoo system;
            switch (savetype)
            {
                case "json":
                    system = new SaveToJson();
                    break;
                case "xmls":
                    system = new SaveToXmls();
                    break;
                default:
                    system = new SaveToTxt();
                    break;
            }
            system.SaveFile(puch, animals);
        }
        public static ObservableCollection<IAnimals> LoadFile(string loadtype, string puch)
        {
            ISaveZoo system;
            switch (loadtype)
            {
                case "json":
                    system = new SaveToJson();
                    break;
                case "xmls":
                    system = new SaveToXmls();
                    break;
                default:
                    system = new SaveToTxt();
                    break;
            }
            return system.LoadFile(puch);
        }
    }
}
