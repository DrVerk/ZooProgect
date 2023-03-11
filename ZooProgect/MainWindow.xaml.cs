using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
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
            presenter = new Presenter();
            viuw.DataContext = presenter.animals;
            add.Click += (e, s) =>
            {
                AddNewAnimal newAnimal = new AddNewAnimal(presenter);
                newAnimal.ShowDialog();
            };
            remuve.Click += (e, s) =>
            presenter.RemoveAnimal((IAnimals)viuw.SelectedItem);
            save.Click += (e, s) =>
            {
                filecontrolWindow filecontrolWindow = new filecontrolWindow(presenter);
                filecontrolWindow.ShowDialog();
            };
        }


    }
}
