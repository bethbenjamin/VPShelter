using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
  public class Employee//this is a base class
    {

        //fields
        private double employeeID;
        private double showID;// abstract
        private double clockIn;// abstract
        //properties 
        //at least one property (EmployeeID)
        public double EmployeeID
        {
            get { return this.employeeID; }
            set { this.employeeID = value; }
        }
        public double ShowID
        {
            get { return this.showID; }
            set { this.showID = value; }
        }
        public double ClockIn
        {
            get { return this.clockIn; }
            set { this.clockIn = value; }
        }
        

        //constructors

        //methods
        //two abstract methods
    } //end class Employee
}//end namespace
