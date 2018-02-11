using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Volunteer:Employee
    {
        //fields
        public string volunteerType;
        public string volunteerName;

        //properties (must add an additional property)
        public string VolunteerType
        {
            get { return this.volunteerType; }
            set { this.volunteerType = value; }
        }
        public string VolunteerName
        {
            get { return this.volunteerName; }
            set { this.volunteerName = value; }
        }
        //constructors
        public Volunteer ()
        {
            //default constructor
        }
        public Volunteer(string volunteerName, string volunteerType)
        {
            VolunteerName = volunteerName;
            VolunteerType = VolunteerType;
        }
        //methods (must contain override method)
        public override double Salary()
        {
            return "You are not eligible for salary.";
        }

        //must contain a method for feeding the pets
    }//end class
}//end namespace
