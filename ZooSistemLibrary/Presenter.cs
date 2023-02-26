using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;

namespace ZooSistemLibrary
{
    public class Presenter : INotifyPropertyChanged
    {
        #region система
        IView view;
        Model model;
        IAnimalsadd animalsadd;
        IFileSystem systemfile;
        SortedDictionary<string, string> file_types = new SortedDictionary<string, string>();
        SortedDictionary<string, string> file_action = new SortedDictionary<string, string>();
        SortedDictionary<string, string> animals_type = new SortedDictionary<string, string>();
        public ObservableCollection<IAnimals> animals { get => model.Animals; set { model.Animals = value; OnPropertyChanged("Animals"); } }
        public Presenter()
        {
            //this.view = view;
            model = new Model();
        }
        public Presenter(IView view) : this()
        {
            this.view = view;

        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        #endregion
        #region функции взаимодействия
        public void SaveAnimals()
        {

        }
        public void LoadAnimals()
        {

        }
        public void ChangeAnimal()
        {

        }
        /// <summary>
        /// добовляет новое животное
        /// </summary>
        public void AddAnimals()
        {
            animals_type.TryGetValue(animalsadd.TipeOfAnimal, out string e);
            model.AddNewAnimals(e, animalsadd.name, animalsadd.Age);
        }

        /// <summary>
        /// удоляет выбраное животное
        /// </summary>
        public void RemoveAnimal(IAnimals animals) =>
            model.RemuveAnimal(animals);
        #endregion
        #region Работа с окнами
        /// <summary>
        /// привязка и обработка окна добавления животного
        /// </summary>
        public void addIAnimalsAdder(IAnimalsadd animalsadd)
        {
            animals_type.Add("Птица", "birds");
            animals_type.Add("Земноводное", "amphibians");
            animals_type.Add("Млекопитающее", "mammal");

            string[] ageAnim = new string[30];
            for (int i = 0; i < ageAnim.Length; i++)
                ageAnim[i] = i.ToString();

            this.animalsadd = animalsadd;
            this.animalsadd.typeofenemyadd = animals_type.Keys;
            this.animalsadd.animalsAges = ageAnim;
        }
        public void bindFileControl(IFileSystem fileSystem)
        {
            systemfile = fileSystem;


            file_types.Add("текст", ".txt");
            file_types.Add("джисон", ".json");
            file_types.Add("таблица", ".xmls");

            systemfile.FileTypeObject = file_types.Keys;

            file_action.Add("Сохронить в фаил", "save");
            file_action.Add("Дозагрузить", "doload");
            file_action.Add("Загрузить в проект", "load");

            systemfile.FileActionObject = file_action.Keys;
        }
        #endregion


    }

}
