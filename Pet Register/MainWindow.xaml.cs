using Pet_Register.ViewModels;
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
        public RegistrationWindow ViewModel { get; private set; } = new RegistrationWindow();

        public MainWindow()
        {
            DataContext = ViewModel;
            InitializeComponent();



        }




    }
        
}