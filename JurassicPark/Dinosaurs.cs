using System;
using System.Collections.Generic;
using System.Text;

namespace JurassicPark
{
    class Dinosaurs
    {
        public string name;
        public string species;
        public int age;
        public float softness; //stats about the animals 

        public void PrintDetails() 
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Age:" + age);
            Console.WriteLine("Species:" + species);
            Console.WriteLine("Softness Lvl:" + softness);

        } // will print info about our animals 

        private void ReleaseTRex()
        {
            Console.WriteLine("The T-Rex was released into the petting zoo paddock.");
        }
        //Unless we need to use the paddock for temporary housing during renovation, we do not want T-Rex in petting zoo!
        private void ReleaseRaptor()
        {
            Console.WriteLine("The Velociraptor was released into the petting zoo paddock.");
        }
        //Unless we need to use the paddock for temporary housing during renovation, we do not want Velociraptor in petting zoo!
        public void ReleaseBaga()
        {
            Console.WriteLine("The Bagaceratops was released into the petting zoo paddock.");
        }
        //Bagaceratops is safe for interactions with guests and can be released without special authorization
        public void ReleaseLiao()
        {
            Console.WriteLine("The Liaoceratops was released into the petting zoo paddock.");
        }
        //Liaoceratops is safe for interactions with guests and can be released without special authorization
        public void ReleaseAgil()
        {
            Console.WriteLine("The Agilisaurus was released into the petting zoo paddock.");
        }
        //Agilisaurus is safe for interactions with guests and can be released without special authorization

        public void PetDino()
        {
            Console.WriteLine("You petted" + name);
            Console.WriteLine("His softness level is" + softness);
        }
        //animals can be petted with this method
    }
}
