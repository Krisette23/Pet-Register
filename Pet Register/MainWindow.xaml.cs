using Petclass;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static Petclass.Pet;

namespace Pet_Register
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly IList<Pet> pets = new ObservableCollection<Pet>();
        public MainWindow()
        {
            InitializeComponent();
            // Convert enum values to list of strings
            List<string> petTypes = Enum.GetNames(typeof(PetType)).ToList();

            // Set the ItemsSource of the ComboBox
            comboBoxPetTypes.ItemsSource = petTypes;

      
        }

  

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAdd_Pet_Click(object sender, RoutedEventArgs e)
        {
            pets.Add(new Pet()  );
        }
    }
}