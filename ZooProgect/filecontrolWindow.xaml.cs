using System.Collections;
using System.Windows;
using ZooSistemLibrary;

namespace ZooProgect
{
    /// <summary>
    /// Логика взаимодействия для filecontrolWindow.xaml
    /// </summary>
    public partial class filecontrolWindow : Window,IFileSystem
    {
        public filecontrolWindow()
        {
            InitializeComponent();
        }
        public filecontrolWindow(Presenter presenter):this() 
        {
            presenter.bindFileControl(this);
            but.Click += delegate { presenter.fileButtonClick(); };
        }

        public string FileName { get => name.Text??"zoo"; set => name.Text=value; }

        public string FileType => (type.SelectedItem??"").ToString();

        public string FileAction => (action.SelectedItem ?? "").ToString();

        public IEnumerable FileTypeObject { set => type.ItemsSource= value; }
        public IEnumerable FileActionObject { set => action.ItemsSource=value; }
    }
}
