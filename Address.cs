// Grading ID:C9022
// Program 0
// CIS 200-01-4168
// September 22, 2016
// This class has 6 properties which are full name, address 1,
// address 2, city name, state name, zip code.  This information
// is to know where the letters and parcels are coming from
// going to. Then places the properties into a string format.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_0
{
    // Address Class
    public class Address
    {
        private string fullName;    // declared variable for their Full Name.
        private string addressLine1;  // declared variable for the 1st Address.
        private string addressLine2;  // declared variable for the 2nd Address.
        private string cityName;  // declared variable for the City.
        private string stateName;  // declared variabe for the State.
        private int zipCode;  // declared variable for the Zip Code.

        const int zip_MAX = 99999; // max zip code constant
        const int zip_MIN = 00000; // min zip code constant

        // Precondition: None
        // Postcondition: putting variables into each argument.
        public Address (string name, string address1, string address2, string city, string state, int zip) // six argument constructor
        {
            fullName = name;
            addressLine1 = address1;
            addressLine2 = address2;
            cityName = city;
            stateName = state;
            zipCode = zip;

        } // end constructor

        // property for fullName
        public string Name
        {
            // Precondition: None
            // Postcondition: return the senders full name.
            get {
                return fullName;
            } // end get

        } // end property

        // property for addressLine1
        public string Address1
        {
            // Precondition: none
            // Postcondition: return address line 1.
            get
            {
                return addressLine1;
            } // end get

        } //end property

        // property for addressLine2
        public string Address2
        {
            // Precondition: none
            // Postcondition: return address line 2
            get
            {
                return addressLine2;
            } // end get

        } // end property

        // property for cityName
        public string City
        {
            // Precondition: none
            // Postcondition: return city name
            get
            {
                return cityName;
            } // end get

        } // end property

        // property for stateName
        public string State
        {
            get
            {
                return stateName;
            } //end get

        } //end property

        // property for zipCode, insure that is more than 10000.
        public int Zip
        {
            // Precondition: None
            // Postcondition: return the zip code.
            get
            {
                return zipCode;
            } // end get

            // Precondition: Zip code >= 00000 and <= 99999.
            // Postcondition: zip code has been specified.
            set
            {
                if ((value >= zip_MIN) && (value <= zip_MAX))// value needs to be greater than 10000
                    zipCode = value; // value assigned to zipCode variable.
                else
                    throw new ArgumentOutOfRangeException("The Zip Code", value, 
                        "must be greater than 00000 but less than 99999.");  // if not 10000 than give exception
            } // end set
        } // end property

        // Precondition: none
        // Postcondition: string displays the senders name, addresses, city, state, and zip code.
        public override string ToString()
        {
            return string.Format($"{Name,-15} {Address1,-25} {Address2,-11} {City,-13} {State,-7} {Zip,8:D5}",
                Name, Address1, Address2, City, State, Zip);
        }

    }
}
