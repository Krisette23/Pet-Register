using System.ComponentModel;
using System.Diagnostics;

namespace Petclass
{
    public class Pet :INotifyPropertyChanged
    {
        public string petID { get; set; }
        public  string petBreed { get; set; }  
        public PetType petType { get; set; }
        public  string petDescription { get; set; }
        public PetType Type { get; set; }
        public string PetID { get; set; }

        public Pet()
        {

        }
      
        public enum PetType
        {
            Dog,
            Cat
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
