using PersonLibrary;
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

namespace PeopleViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PeopleRepository peopleRepo = new PeopleRepository();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConcreteFetchButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();

            List<Person> people;
            people = peopleRepo.GetPeople();
            PersonListBox.ItemsSource = people;
            //foreach (var person in people)
            //    PersonListBox.Items.Add(person);
        }

        private void InterfaceFetchButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();

            IEnumerable<Person> people;
            people = peopleRepo.GetPeople();
            PersonListBox.ItemsSource = people;
            //foreach (var person in people)
            //    PersonListBox.Items.Add(person);
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
        }

        private void ClearListBox()
        {
            //PersonListBox.Items.Clear();
            PersonListBox.ItemsSource = null;
        }
    }
}
