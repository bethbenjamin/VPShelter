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
            Thunderbird thunder = new Thunderbird("Frank", "Eagle faced Hippogriff");
            ////base class employee
            ////objects of employee are 1 manager and 2 volunteers

            Manager managerOne = new Manager("Rubeus Hagrid");

            Volunteer volunteer = new Volunteer();
            Volunteer volunteerOne = new Volunteer("Newton Scamander","");
            Volunteer volunteerTwo = new Volunteer("Jacob Kowalski", "");
            ////required employeeID 
            managerOne.EmployeeID = 8675309;
            volunteerOne.EmployeeID = 62442;
            volunteerTwo.EmployeeID = 394;

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
                        Console.WriteLine("To Show ID, press 1");
                        Console.WriteLine("To view salary, press 2");
                        Console.WriteLine("To view Magical Creatures for adoption, press 3");
                        Console.WriteLine("Adopt a Magical Creature, press 4 ");
                        Console.WriteLine("To play with Magical Creatures, press 5");
                        Console.WriteLine("Exit, press 6");

                        choice = int.Parse(Console.ReadLine());

                        string creatureAdoption = Console.ReadLine(); // adding a string for adoption for switch
                        switch (choice)
                        {
                            case 1://show ID
                                Console.WriteLine(managerOne.ShowID());
                                Console.WriteLine("(Name)   (ID)");
                                Console.WriteLine("{ 0} { 1}", managerOne.managerName, managerOne.showID);
                                break;
                            case 2://manager salary
                                Console.WriteLine("Manager's salary");
                                Console.WriteLine(managerOne.Salary() + "" + "Galleons");

                                Console.WriteLine();
                                break;
                            case 3://view inventory
                                Console.Clear();
                                Console.WriteLine("Magical Creature Inventory");
                                Console.WriteLine("Creature Name   Description");
                                Console.WriteLine("{0}", petOne);
                                Console.WriteLine("{0}", petTwo);
                                Console.WriteLine("{0}", thunder);
                                break;
                            case 4: //view / choose pets for adoption.
                                Console.Clear();
                                Console.WriteLine("Creatures that still need adopting:");
                                Console.WriteLine("{0}, {1}, {2}", petOne, petTwo, thunder);
                                if (creatureAdoption == "petOne")
                                {
                                    Console.WriteLine("Draco is packed and ready for your cave.");
                                }
                                else if (creatureAdoption == "petTwo")
                                {
                                    Console.WriteLine("Thunderbird makes a fantastic pet");
                                }
                                else
                                {
                                    Console.WriteLine("Frank is a Hip - Hippogriff. Respect is everytihng.");
                                }
                                break;
                            case 5: //manager plays with creatures
                                Console.Clear();
                                Console.WriteLine("You have played with the Magical Creatures");
                                petOne.Play();//draco method play
                                petTwo.Play();//Thunderbird method play
                                thunder.Play();//Frank method play
                                break;
                        }//end switch

                    } while (choice != 5);//end do
                }//end if

                else // this is the volunteer section of the menu
                {
                    Console.WriteLine("Volunteer Menu");
                    Console.WriteLine("To show ID, press 1");
                    Console.WriteLine("To see volunteer names, press 2");
                    Console.WriteLine("To feed all creatures, press 3");
                    Console.WriteLine("To water all creatures, press 4");
                    Console.WriteLine("To clean the cave, press 5");
                    Console.WriteLine("Exit, press 6");
                    choice = int.Parse(Console.ReadLine());

                    //user makes choice - 1-5
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Your ID is:");
                            //Console.WriteLine(volunteer.ShowID);
                            break;
                        case 2:
                            Console.WriteLine("Volunteer Names are:");
                            Console.WriteLine(volunteerOne);
                            Console.WriteLine(volunteerTwo);
                            break;
                        case 3:
                            Console.WriteLine("You have fed all creatures");
                            break;
                        case 4:
                            Console.WriteLine("You have watered all creatures");
                            break;
                        case 5:
                            Console.WriteLine("You have cleaned the cave.");
                            break;
                        case 6:
                            Console.WriteLine("Exit");
                            break;
                    } //end switch
                } // end else 

            } while (choice != 6);//end do // 6 choices 
        }//end Main     
    }//end class Program
} //end of namespace
