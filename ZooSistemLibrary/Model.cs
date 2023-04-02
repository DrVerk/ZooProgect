using System.Collections.ObjectModel;
using System.Collections.Generic;
using ZooSistemLibrary.Interfase;
using System;

namespace ZooSistemLibrary
{
    internal class Model
    {
        public ObservableCollection<IAnimals> Animals { get; set; }
        public static SortedDictionary<string, string> file_types = new SortedDictionary<string, string>();
        public static SortedDictionary<string, string> file_action = new SortedDictionary<string, string>();
        public static SortedDictionary<string, string> animals_type = new SortedDictionary<string, string>();
        static string[] ageAnim = new string[30];
        static Model()
        {
            file_types.Add("текст", "txt");
            file_types.Add("джисон", "json");
            file_types.Add("таблица", "xmls");
            file_action.Add("Сохронить в фаил", "save");
            file_action.Add("Дозагрузить", "doload");
            file_action.Add("Загрузить в проект", "load");
            animals_type.Add("Птица", "birds");
            animals_type.Add("Земноводное", "amphibians");
            animals_type.Add("Млекопитающее", "mammal");
            for (int i = 0; i < ageAnim.Length; i++)
                ageAnim[i] = i.ToString();
        }
        public Model()
        {
            Animals = new ObservableCollection<IAnimals>();
        }
        public void AddNewAnimals()
        {
            Animals.Add(AnimalsFactory.AnimalsCreate("", "", ""));
        }
        public void AddNewAnimals(
            IAnimalsadd animalsadd,
            string name,
            string age)
        {
            animals_type.TryGetValue(animalsadd.TipeOfAnimal, out string e);
            Animals.Add(AnimalsFactory.AnimalsCreate(e, name, age));
        }

        public void RemuveAnimal(IAnimals animals)
        {
            Animals.Remove(animals);
        }
        public void SaveAnimals(string savetype, string puch, ObservableCollection<IAnimals> animals) =>
            SaveFileFactory.SaveFile(savetype, puch, animals);

        public ObservableCollection<IAnimals> LoadAnimals(string loadtype, string puch) =>
             SaveFileFactory.LoadFile(loadtype, puch);


        public void fileGUI(IFileSystem systemfile)
        {
            systemfile.FileTypeObject = file_types.Keys;
            systemfile.FileActionObject = file_action.Keys;
        }

        internal void addAnimalsGUI(IAnimalsadd animalsadd)
        {
            animalsadd.typeofenemyadd = animals_type.Keys;
            animalsadd.animalsAges = ageAnim;
        }

        internal void ChangeZooGUI(IChangeZoo changeZoo)
        {
            changeZoo.animalsAges = ageAnim;
            changeZoo.animalsType = animals_type.Keys;
        }
    }

}
