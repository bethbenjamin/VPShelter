using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Manager : Employee //manager derived from base class Employee
    {
        //fields
        public string managerName;
        public double showID;
        public double salary;

        //properties(must contain an additonal property)
        public string ManagerName
        {
            get { return this.managerName; }
            set { this.managerName = value; }
        }
   
        //constructors
        public Manager()
        {
            //default constructor
        }
        public Manager(string managerName)
        {
            ManagerName = managerName;
        }
      

        //methods (must contain an override method and a method for adopting a pet)
        public string Adoption()
        {
            return "The magical creature has been placed.";
        }
        public override double Salary()
        {
            return 50000;
        }
        public override double ShowID()
        {
            return EmployeeID;
        }
    

    }//end class Manager
}//end Namespace
