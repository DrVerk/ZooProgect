using System.Collections.Generic;
using System.Windows;
using ZooSistemLibrary;

namespace ZooProgect
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IView
    {
        Presenter presenter;
        public MainWindow()
        {
            InitializeComponent();
            presenter = new Presenter(this);
            add.Click += (e, s) =>
                new AddNewAnimal(presenter).ShowDialog();
            remuve.Click += (e, s) =>
                presenter.RemoveAnimal();
            rename.Click += (e, s) => {if (animal == null) return;
                new ChangeZooWindow(presenter).ShowDialog(); };
                
            save.Click += (e, s) =>
                new filecontrolWindow(presenter).ShowDialog();
        }

        public IEnumerable<IAnimals> Views { get => (IEnumerable<IAnimals>)viuw.DataContext; set => viuw.DataContext = value; }

        public IAnimals animal => (IAnimals)viuw.SelectedItem;
    }
}
