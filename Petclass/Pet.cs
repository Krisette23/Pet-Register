using System.Diagnostics;

namespace Petclass
{
    public class Pet
    {
        public string petID { get; set; }
        public  string petName { get; set; }  
        public PetBreed petBreed { get; set; }
        public  string petDescription { get; set; }

        public Pet()
        {

        }
      
        public enum PetBreed
        {
            Dog,
            Cat,
            Bird,
            Fish,
            Rabbit,
            Hamster,
            GuineaPig,
            Ferret,
            Turtle,
            Lizard,
            Snake,
            Spider,
        }
    }
}
