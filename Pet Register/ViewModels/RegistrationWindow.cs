using Pet_Register.Commands;
using Petclass;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static Petclass.Pet;

namespace Pet_Register.ViewModels
{
 public class RegistrationWindow : INotifyPropertyChanged
    {

        
        public ObservableCollection<Pet> Pets { get; set; } = new ObservableCollection<Pet>();
        public ObservableCollection<string> PetTypes { get; set; } = new ObservableCollection<string>();
   
        public ICommand AddPetCmd { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        //private void MenuItem_Click(object sender, RoutedEventArgs e)
        //{
        //    this.Close();
        //}


        public bool CanAddPet()
        {
            return !string.IsNullOrEmpty(SelectedPet.petID) && !string.IsNullOrEmpty(SelectedPetType);
        }

        public Pet _selectedPet;
        public Pet SelectedPet
        {
            get => _selectedPet;
            set
            {
                _selectedPet = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedPet)));
            }
        }

        public string _selectedPetType;
        public string SelectedPetType
        {
            get => _selectedPetType;
            set
            {
                _selectedPetType = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedPetType)));
            }

        }

        private void AddPet()
        {

            Pets.Add(new Pet { PetID = SelectedPet.petID, Type = (PetType)Enum.Parse(typeof(PetType), SelectedPetType) });
        }

        public RegistrationWindow()
        {

            Pets = new ObservableCollection<Pet>();
            PetTypes = new ObservableCollection<string>(Enum.GetNames(typeof(PetType)).ToList());
            AddPetCmd = new RelayCommand(AddPet, CanAddPet);   
        }
    }
}
