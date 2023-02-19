﻿using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using ZooSistemLibrary;
using ZooSistemLibrary.Interfase;

namespace ZooProgect
{
    /// <summary>
    /// Логика взаимодействия для AddNewAnimal.xaml
    /// </summary>
    public partial class AddNewAnimal : Window, IAnimalsadd
    {

        public AddNewAnimal()
        {
            string[] objectsAnim = { "birds", "amphibians", "mammal" };
            InitializeComponent();
            typeofenemy.ItemsSource = objectsAnim;
            for (int i = 0; i < 30; i++)
                age.Items.Add(i);
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
    }
}
