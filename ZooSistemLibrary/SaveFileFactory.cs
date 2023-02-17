using System.Collections.ObjectModel;
using System.Security.AccessControl;

namespace ZooSistemLibrary
{
    static class SaveFileFactory
    {
        public static void SaveFile(string savetype,string puch, ObservableCollection<IAnimals> animals)
        {
            switch (savetype)
            {
                case "json":

                    break;
                case "xmls":

                    break;
                default:

                    break;
            }
        }
        public static void LoadFile(string loadtype,string puch,ref ObservableCollection<IAnimals> animals)
        {
            switch (loadtype)
            {
                case "json":

                    break;
                case "xmls":

                    break;
                default:

                    break;
            }
        }
    }
}
