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

    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

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
            get { return _selectedPetType; }
            set
            {
                _selectedPetType = value;
                OnPropertyChanged();
            }

        }
        private string _statusMessage;
        public string StatusMessage
        {
            get => _statusMessage;
            set
            {
                _statusMessage = value;
                OnPropertyChanged();
        }
        private void AddPet()
        {
            if (!string.IsNullOrWhiteSpace(SelectedPetType))
            { 
                SelectedPet.Type = (PetType)Enum.Parse(typeof(PetType), SelectedPetType);
                StatusMessage = "Pet added successfully";
            }

            else
            {
                StatusMessage = "Please select a pet type";
            }
                /*Pets.Add(new Pet { PetID = SelectedPet.petID, Type = (PetType)Enum.Parse(typeof(PetType), SelectedPetType) })*/;
            StatusMessage = "Pet added successfully";
        }

        public RegistrationWindow()
        {

            Pets = new ObservableCollection<Pet>();
            PetTypes = new ObservableCollection<string>(Enum.GetNames(typeof(PetType)).ToList());
            AddPetCmd = new RelayCommand(AddPet, CanAddPet);
            ExitApplicationCommand = new RelayCommand(ExitApplication);
        }


        //Commands 

        public ICommand ExitApplicationCommand { get; set; }
        private void ExitApplication()
        {
            App.Current.Shutdown();
        }

    }
}
