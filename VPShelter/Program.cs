using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Program
    {
        static void Main(string[] args)
        {

            /*have a method that asks for user input 
             * writes output to the console 
             volunteers should be able to at least feed all pets, water all pets
             volunteer or manager play with individual pet
             manager to coordinate adoption of a pet which should display 
             a list of pet names and descriptions allowing a user to selct one*/
           
            //objects of VirtualPet (Name, What they eat)
            VirtualPet pet = new VirtualPet();
            VirtualPet petOne = new VirtualPet("Draco", "Fwoopers");
            VirtualPet petTwo = new VirtualPet("Thunderbird", "Pygmy Puffs");
            //base class employee
            //objects of employee are 1 manager and 2 volunteers

            Manager managerOne = new Manager("Rubeus Hagrid");
            Volunteer volOne = new Volunteer("Newton Scamander");
            Volunteer volTwo = new Volunteer("Jacob Kowalski");

            

        }//end main
    } //end of class
} //end of namespace
