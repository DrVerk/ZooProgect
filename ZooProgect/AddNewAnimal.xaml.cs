using System.Collections;
using System.Windows;
using ZooSistemLibrary;

namespace ZooProgect
{
    /// <summary>
    /// Логика взаимодействия для AddNewAnimal.xaml
    /// </summary>
    public partial class AddNewAnimal : Window, IAnimalsadd
    {

        public AddNewAnimal()
        {
            InitializeComponent();
            cancel.Click += delegate { DialogResult = false; };
        }
        public AddNewAnimal(Presenter presenter) : this()
        {
            presenter.addIAnimalsAdder(this);
            load.Click += delegate { presenter.AddAnimals(); };
        }
        public string Age => (age.SelectedItem ?? 0).ToString();
        public string TipeOfAnimal => (string)typeofenemy.SelectedItem ?? "";
        public string name { get => Mame.Text; }
        public IEnumerable typeofenemyadd { set => typeofenemy.ItemsSource = value; }
        public IEnumerable animalsAges { set => age.ItemsSource = value; }
    }
}
