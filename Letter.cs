// Grading ID:C9022
// Program 0
// CIS 200-01-4168
// September 22, 2016
// This a derived class of the Parcel class.
// It takes in Parcel class information about the origin and destination class.
// But adds an additional property called Calc cost which finds the shipping cost.
// Then adds the shipping cost into the overridden string format.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_0
{
    // Letter is a derived class of the Parcel class.
    public class Letter : Parcel
    {
        private decimal fixedCost;  // declared variable for shipping cost.

        // Precondition: None
        // Postcondition: put variables into the three arguments
        public Letter (Address origin, Address destination, decimal cost) : base (origin, destination) // three argument constructor
        {
            fixedCost = cost; // Shipping Cost agrument.

        }

        // property for fixedCost.
        private decimal ShipCost
        {
            // Precondition: None
            // Postcondition: return the shipping cost.
            get {
                    return fixedCost; 
                } // end get

            // Precondition: Cost is more than 0.
            // Postcondition: display either shipping cost or exception error.
            set
            {
                if (value >= 0)   // insure that value equals a postive number.
                    fixedCost = value;  // value assigned cost.
                else
                    throw new ArgumentOutOfRangeException("Shipping Cost",
                        value, "must be greater than 0");  // if the number is negative than out of range exception is given.
            }  // end set
        } // end property 

        // Precondition: shipping cost is greater than zero
        // Postcondition: return the shipping cost.
        public override decimal CalcCost()
        {
            return ShipCost;  // assign shipping cost property to the Calculated Cost.
        }  // end property

        // Precondition: None
        // Postcondition: a string is returned adding shipping cost to it.
        public override string ToString()
        {
            return string.Format($"From:   { OriginAddress,-19} \nTo:     { DestinationAddress,-19} \nCost:{ShipCost,13:C}", 
                base.ToString(), ShipCost);  // display base string and added Shipping cost.
                
        }

    }
}
