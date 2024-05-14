using System.Diagnostics;

namespace Petclass
{
    public class Pet
    {
        public string petID { get; set; }
        public  string petBreed { get; set; }  
        public PetType petType { get; set; }
        public  string petDescription { get; set; }

        public Pet()
        {

        }
      
        public enum PetType
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
            Spider
        }
    }
}
