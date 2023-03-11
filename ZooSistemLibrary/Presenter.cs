﻿using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ZooSistemLibrary
{
    public class Presenter : INotifyPropertyChanged
    {
        #region система
        IView view;
        Model model;
        IAnimalsadd animalsadd;
        IFileSystem fileSystem;

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
        /// <summary>
        /// отрабатывает взаимодействие с кнопкой в окне файлов
        /// </summary>
        public void fileButtonClick()
        {
            model.file_types.TryGetValue(fileSystem.FileType, out string e);
            model.SaveAnimals(e, fileSystem.FileName, animals);
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
        public void RemoveAnimal(IAnimals animals) =>
            model.RemuveAnimal(animals);
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

        #endregion


    }

}
