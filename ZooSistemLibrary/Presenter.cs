using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ZooSistemLibrary.Interfase;

namespace ZooSistemLibrary
{
    public class Presenter : INotifyPropertyChanged
    {
        #region система
        IView view;
        Model model;
        IAnimalsadd animalsadd;
        IFileSystem fileSystem;
        IChangeZoo changeZoo;
        public ObservableCollection<IAnimals> animals { get => model.Animals; set { model.Animals = value; OnPropertyChanged("Animals"); } }
        public Presenter()
        {
            model = new Model();
        }
        public Presenter(IView view) : this()
        {
            this.view = view;
            this.view.Views = animals;

        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        #endregion
        #region функции взаимодействия
        /// <summary>
        /// отрабатывает взаимодействие с кнопкой в окне файлов
        /// </summary>
        public void fileButtonClick()
        {
            Model.file_types.TryGetValue(fileSystem.FileType, out string e);
            Model.file_action.TryGetValue(fileSystem.FileAction, out string s);
            switch (s)
            {
                case "save":
                    model.SaveAnimals(e, fileSystem.FileName, animals);
                    break;
                case "doload":
                    var mod = model.LoadAnimals(e, fileSystem.FileName);
                    foreach (var item in mod)
                        animals.Add(item);
                    break;
                case "load":
                    animals = model.LoadAnimals(e, fileSystem.FileName);
                    break;
            }

        }
        /// <summary>
        /// добовляет новое животное
        /// </summary>
        public void AddAnimals()
        {

            model.AddNewAnimals(animalsadd, animalsadd.name, animalsadd.Age);
        }

        /// <summary>
        /// удоляет выбраное животное
        /// </summary>
        public void RemoveAnimal() =>
            model.RemuveAnimal(view.animal);
        public void CangeZooSave()
        {
            IAnimals _animal = view.animal;

            view.animal.Age = changeZoo.Age;
            view.animal.Name = changeZoo.NameAnimal;
            view.animal.TipeOfAnimal = changeZoo.TipeOfAnimal;
            animals.Add(view.animal);
            animals.Remove(_animal);
        }
        #endregion
        #region Работа с окнами
        /// <summary>
        /// привязка и обработка окна добавления животного
        /// </summary>
        public void addIAnimalsAdder(IAnimalsadd animalsadd)
        {
            this.animalsadd = animalsadd;
            model.addAnimalsGUI(this.animalsadd);
        }
        /// <summary>
        /// привязка и обработка окна работы с файлами
        /// </summary>
        /// <param name="fileSystem"></param>
        public void bindFileControl(IFileSystem file)
        {
            fileSystem = file;
            model.fileGUI(fileSystem);
        }
        public void bindChangeZoo(IChangeZoo changezoo)
        {
            if (view.animal == null)
                return;
            changeZoo = changezoo;
            changeZoo.Age = view.animal.Age;
            changeZoo.NameAnimal = view.animal.Name;
            changeZoo.TipeOfAnimal = view.animal.TipeOfAnimal;
            model.ChangeZooGUI(changeZoo);

        }






        #endregion


    }

}
