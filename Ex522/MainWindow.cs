//using System.ComponentModel; INotifyPropertyChanged

using System.Windows;

namespace Ex522
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataNumber data = new DataNumber();

        public MainWindow()
        {
            InitializeComponent();

            list.ItemsSource = data.col;



            btnAdd.Click += delegate { data.AddElemnt(); };
            btnSort.Click += delegate { data.Sort(); };
            btnBSort.Click += delegate { data.BSort(); };
            btnMix.Click += delegate { data.Mix(); }; //ShakerSort
            btnShaker.Click += delegate { data.ShakerSort(); }; //
        }
    }
}
