using System.Diagnostics;

namespace Petclass
{
    public class Pet
    {
        public string PetID { get; set; }
        public  string PetName { get; set; }  
        public  string PetType { get; set; }
        public  string PetBreed { get; set; }
        public  string PetDescription { get; set; }

        public Pet()
        {

        }
        public Pet (string petName, string petType, string petBreed)
        {

         PetName = petName;
         PetType = petType;
         PetBreed = petBreed;   

            
        }
    }
}
