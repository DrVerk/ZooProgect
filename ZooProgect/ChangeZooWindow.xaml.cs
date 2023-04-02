using System;
using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using ZooSistemLibrary;
using ZooSistemLibrary.Interfase;

namespace ZooProgect
{
    /// <summary>
    /// Логика взаимодействия для ChangeZooWindow.xaml
    /// </summary>
    public partial class ChangeZooWindow : Window, IChangeZoo
    {

        public ChangeZooWindow()
        {
            InitializeComponent();
            Return.Click += delegate { DialogResult = false; };

        }
        public ChangeZooWindow(Presenter presenter) : this()
        {
            presenter.bindChangeZoo(this);

            Save.Click += delegate
            {
                presenter.CangeZooSave();
                DialogResult = false;
            };
        }


        public IEnumerable animalsAges { set => age.ItemsSource = value; }

        public IEnumerable animalsType { set => type.ItemsSource = value; }
        public string Age { get => (age.SelectedItem??"Возраст не определен").ToString(); set => age.SelectedItem = value; }
        public string TipeOfAnimal { get => (type.SelectedItem ?? "Вид не определен").ToString(); set => type.SelectedItem = value; }
        public string NameAnimal { get => x_n.Text; set => x_n.Text = value; }
    }
}
