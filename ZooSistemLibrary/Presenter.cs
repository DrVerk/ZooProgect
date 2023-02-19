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
        public void AddAnimals()
        {
            model.AddNewAnimals(animalsadd.TipeOfAnimal, animalsadd.name, animalsadd.Age);
        }
        public void addIAnimalsAdder(IAnimalsadd animalsadd)
        {
            this.animalsadd = animalsadd;
        }
        public void RemoveAnimal(IAnimals animals)
        {
            model.RemuveAnimal(animals);
        }
        public void ChangeAnimal()
        {

        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }

}
