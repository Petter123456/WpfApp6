using System.Collections.ObjectModel;
using System.Windows;
using System.ComponentModel;
using System.Linq;
using System.Windows.Controls;
using System.Xml.Linq;
using WpfApp6;

namespace MSDNTest
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();         

            listOfUsers = new ObservableCollection<User>();
            listOfAdmin = new ObservableCollection<User>();

            listBox.ItemsSource = listOfUsers;
            adminListBox.ItemsSource = listOfAdmin; 

            button.Click += (s, e) =>
            {
                if (textBox.Text.Length > 0 && listBox.SelectedItem != null)
                    ((User)listBox.SelectedItem).Name = textBox.Text;
            };
        }

        private static ObservableCollection<User> _listOfUsers;
        public ObservableCollection<User> listOfUsers
        {
            get { return _listOfUsers; }
            set { _listOfUsers = value; }
        }

        private static ObservableCollection<User> _listOfAdmin;

        public ObservableCollection<User> listOfAdmin
        {
            get { return _listOfAdmin; }
            set { _listOfAdmin = value; }
        }

        private void delete(object sender, RoutedEventArgs e)
        {
            var currentUser = ((User)listBox.SelectedItem);
            listOfUsers.Remove(currentUser);
        }

        private void add(object sender, RoutedEventArgs e)
        {
            listOfUsers.Add(new User(name.Text.ToString(), email.Text.ToString()));

            name.Clear();
            email.Clear();
        }

        private void MakeAdmin(object sender, RoutedEventArgs e)
        {
            var currentUser = ((User)listBox.SelectedItem);

            listOfAdmin.Add(currentUser); 
        
        }

        private void DeleteAdmin(object sender, RoutedEventArgs e)
        {
            var currentUser = ((User)listBox.SelectedItem);

            listOfAdmin.Remove(currentUser);
        }
    }
}