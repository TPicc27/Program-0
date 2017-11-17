// Grading ID:C9022
// Program 0
// CIS 200-01-4168
// September 22, 2016
// This program displays query with letters that display 
// the senders information with name, their address, possibly another address,
// their city, state, and zip code.  Same thing occurs for the people receiving
// the letter.  The parcels follow the same procedure with information from
// sender to person receiving the parcel.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_0
{
    // Test program
    class Program
    {
        // Precondition: None
        // Postcondition: Display query of selected material.
        static void Main(string[] args)
        {
            // Address objects for each sender and reciever
            Address address1 = new Address("Timmy Turner", "14589 Grant Avenue", "None", "Atlanta", "GA", 45693); // declaring address 1
            Address address2 = new Address("Carey Williams", "34563 Lava Street", "None", "Louisville", "KY", 40345); // declaring address 2
            Address address3 = new Address("Flash Gordon", "23453 Pacific Drive", "None", "Oakland", "CA", 23456); // declaring address 3
            Address address4 = new Address("Jessica Oak", "14563 Landshore Court", "None", "Miami", "FL", 54002); // declaring address 4

            // Letter objects that has address objects inside
            Letter letter1 = new Letter(address1, address3, 12.5m); // declaring letter 1
            Letter letter2 = new Letter(address3, address2, 17.85m); // declaring letter 2
            Letter letter3 = new Letter(address4, address1, 11); // declaring letter 3

            Console.WriteLine("Letters going from sender to receiver:");
            Console.WriteLine("Letters     Full Name       Address 1           Address 2       City        State      Zip Code");
            Console.WriteLine("-------     ---------      -----------          ---------     -------       -----      --------"); // Column Headers

            Console.WriteLine(letter1);  // display letter 1

            Console.WriteLine(); // spacing
            Console.WriteLine(letter2);  // displaying letter 2

            Console.WriteLine();  // spacing
            Console.WriteLine(letter3); // displaying letter 3

            // Putting the Letter objects into a list of Parcel Objects
            List<Parcel> parcels = new List<Parcel>();
            Console.WriteLine("\nDisplay Parcels from sender to receiver:"); // Column Headers
            Console.WriteLine("Parcels");
            Console.WriteLine("-------"); 
            parcels.Add(letter1); // adding letter 1 object to parcel list
            parcels.Add(letter2); // adding letter 2 object to parcel list
            parcels.Add(letter3); // adding letter 3 object to parcel list

           foreach(var parcel in parcels) // display the objects through a foreach statement.
                Console.WriteLine("{0} \n", parcel);

        }
    }
}
