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

            //objects of VirtualPet (Name, description)
            VirtualPet pet = new VirtualPet();
            VirtualPet petOne = new VirtualPet("Draco", "Large Dragon");
            VirtualPet petTwo = new VirtualPet("Thunderbird", "Eagle faced Hippogriff ");
            Thunderbird thunderOne = new Thunderbird("Frank", "Eagle faced Hippogriff");
            //base class employee
            //objects of employee are 1 manager and 2 volunteers

            Manager managerOne = new Manager("Rubeus Hagrid");

            Volunteer vol = new Volunteer();
            Volunteer volOne = new Volunteer("Newton Scamander");
            Volunteer volTwo = new Volunteer("Jacob Kowalski");
            //required employeeID 
            managerOne.EmployeeID = 8675309;
            volOne.EmployeeID = 62442;
            volTwo.EmployeeID = 394;

            int choice = 0;
            // do while loop
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to Hagrid's Care of Magical Creatures Shelter");
                Console.WriteLine("If you are a manager, please press 1");
                Console.WriteLine("If you are a volunteer, please press 2");
                Console.WriteLine("View inventory of Magical Creatures, press 3");
                Console.WriteLine("To exit or leave Hagrid's Care of Magical Creatures Shelter, press 3");
                choice = int.Parse(Console.ReadLine());


                //have user choose manager or vol
                Console.WriteLine("Please choose if you are a manager or volunteer");
                Console.WriteLine("Manager press 1");
                Console.WriteLine("Volunteer press 2");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine();


                // in the menu, add a switch for manager or volunteer menu
                if (choice == 1)
                {
                    do
                    {
                        Console.WriteLine("Manager Menu");
                        Console.WriteLine("------------");
                        Console.WriteLine("To check in, press 1");
                        Console.WriteLine("To adopt out a Magical Creature, press 2");
                        choice = int.Parse(Console.ReadLine());

                        switch (choice)
                        {
                            case 1://vol info
                                Console.WriteLine("Care of Magical Creature Employee Info:");
                                Console.WriteLine("(Name)   (ID)  (Hours worked)");
                                Console.WriteLine("");
                                break;
                            case 2://manager clockin
                                Console.WriteLine(managerOne.ClockIn());
                                Console.WriteLine("Manager has clocked in");
                                Console.WriteLine();
                                break;
                            case 3://view inventory
                                Console.Clear();
                                Console.WriteLine("Magical Creature Inventory");
                                Console.WriteLine("Creature Name   Description");

                                break;

                        }//end switch

                    } while (choice != 4);//end do
                }//end if









            } while (choice != 2);//end do
        }//end Main     
    }//end class Program
} //end of namespace
