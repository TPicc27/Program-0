// Grading ID:C9022
// Program 0
// CIS 200-01-4168
// September 22, 2016
// This is a base class that takes the implements information from the Address class
// and puts it into the origin address and destination address.  Has
// a constructor for the two properties. Putting the two properties into string format
// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_0
{ 
    // Parcel class
    public abstract class Parcel
    {
        public Address OriginAddress { get; private set; }  // auto-implemented property for Origin Address

        public Address DestinationAddress { get; private set; }  // auto-implemented property for Destination Address

        // Precondition: None
        // Postcondition: place variables into the two arguments
        public Parcel (Address origin, Address destination) // two argument constructor
        {
            OriginAddress = origin;
            DestinationAddress = destination;
        
        }  // end of constructor


        // Precondition: None
        // Postcondition: A string is returned showing the origin and destination address
        public override string ToString()
        {
            return string.Format($"From:  {OriginAddress,-19} \n To:  {DestinationAddress,-19}");  // string interpolation
                
        }


        // Precondition: None
        // Postcondition: return the shipping cost
        public abstract decimal CalcCost(); // abstract class that is overridden in the Letter class.
    }

}
