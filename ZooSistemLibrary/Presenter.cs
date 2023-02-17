using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ZooSistemLibrary
{
    public class Presenter : INotifyPropertyChanged
    {
        IView view;
        Model model;

        

        public ObservableCollection<IAnimals> animals { get => model.Animals; set { model.Animals = value; OnPropertyChanged("animals"); } }
        public Presenter()
        {
            //this.view = view;
            model = new Model();
        }
        public Presenter(IView view) :this() 
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
            model.AddNewAnimals();
        }
        public void RemoveAnimal()
        {

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
