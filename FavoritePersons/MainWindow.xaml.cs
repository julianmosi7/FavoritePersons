using NorthwindDbLib;
using PersonalDbLib;
using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ViewModelLib;

namespace FavoritePersons
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private ViewModel viewModel;
        private PersonalContext personalDb;
        private NorthwindContext northwindDb;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ConnectionString();
            personalDb = new PersonalContext("PersonalContext").SeedIfEmpty();
            northwindDb = new NorthwindContext();
            viewModel = new ViewModel(personalDb, northwindDb);
            DataContext = viewModel;
            AccessDatabase();
        }

        private void ConnectionString()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
        }

        private void AccessDatabase()
        {
            try
            {
                int nrp = personalDb.Customers.Count();
                Console.WriteLine($"Nr Customers Personal: {nrp}");
                int nrn = northwindDb.Customers.Count();
                Console.WriteLine($"Nr Customers Northwind: {nrn}");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
