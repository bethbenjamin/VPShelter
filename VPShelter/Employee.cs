using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
  public abstract class Employee//this is an abstract base class
    {

        //fields
        private double employeeID;
        private double showID;// abstract
        private double salary;// abstract
        //properties 
        //at least one property (EmployeeID)
        public double EmployeeID
        {
            get { return this.employeeID; }
           
        }
       
        


        //constructors

        //methods
        //two abstract methods  // must call from class as abstract
        public abstract double Salary();
        public abstract double ShowID();


    } //end class Employee
}//end namespace
