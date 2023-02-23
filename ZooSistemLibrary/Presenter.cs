using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ZooSistemLibrary.Interfase;

namespace ZooSistemLibrary
{
    public class Presenter : INotifyPropertyChanged
    {
        IView view;
        Model model;
        IAnimalsadd animalsadd;


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
        public void AddAnimals() =>
            model.AddNewAnimals(animalsadd.TipeOfAnimal, animalsadd.name, animalsadd.Age);
        /// <summary>
        /// удоляет выбраное животное
        /// </summary>
        public void RemoveAnimal(IAnimals animals) =>
            model.RemuveAnimal(animals);
        /// <summary>
        /// привязка и обработка окна добавления животного
        /// </summary>
        public void addIAnimalsAdder(IAnimalsadd animalsadd)
        {
            string[] objectsAnim = { "birds", "amphibians", "mammal" };
            string[] ageAnim = new string[30];
            for (int i = 0; i < 30; i++)
                ageAnim[i] = i.ToString();
            this.animalsadd = animalsadd;
            this.animalsadd.typeofenemyadd = objectsAnim;
            this.animalsadd.animalsAges = ageAnim;
        }

      
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }

}
