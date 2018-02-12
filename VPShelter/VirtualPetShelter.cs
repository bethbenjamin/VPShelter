using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class VirtualPetShelter//think of this like the client class (not connected to anything)
    {

        //fields
        //fields and properties should store all of the pets and all of the employees
        //include appropriate  instance variables (fields properties) to store the pets who reside  at the shelter
        //include appropriate instance variables (fields/properties) to store all employees who volunteer or work at the shelter.


        //(LIST LIST LIST)
        //hidden fields add lists in properties


         //im going to try and add lists for both petshelter and shelteremployee
        //properties
        public List<VirtualPet>MagicalPetList { get; set; } //added this way bc field is invisible
        public List<Employee>MagicalEmployeeList { get; set; }//added this way bc field is invisible // also when i set the fields // i cant figure out how to call them in properties.
                                                              //without getting errors.

        //constructors
        // i dont think there shoud be any constructors since it's an abstract class???
        //ref: microsoft.com Rule Description
        //Constructors on abstract types can be called only by derived types.Because public constructors create instances of a type, and you cannot create instances of an abstract type, an abstract type that has a public constructor is incorrectly designed.
        //methods
    }//end of Class VirtualPetshelter 
}//end of Namespace
