using Petclass;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static Petclass.Pet;

namespace Pet_Register.ViewModels
{
 public class RegistrationWindow
    {

        public IList<Pet> pets { get; set; } = new ObservableCollection<Pet>();
        // Convert enum values to list of strings
        List<string> petTypes = Enum.GetNames(typeof(PetType)).ToList();

        // Set the ItemsSource of the ComboBox
        comboBoxPetTypes.ItemsSource = petTypes;
    }
}
