using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSistemLibrary
{
    public class Presenter
    {
        IView view;
        Model model;

        public Presenter(IView view)
        {
            this.view = view;
            model= new Model();
        }
        public void SaveAnimals()
        {

        }
        public void LoadAnimals()
        {

        }
        public void AddAnimals()
        {

        }
        public void RemoveAnimals()
        {

        }
    }
}
