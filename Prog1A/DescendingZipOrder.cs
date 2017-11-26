//Grading ID: C4811
// Program 4
// CIS 200-01
// Due: 11/29/16
// this class provides an IComparer for the Parcel class
// that orders the objects in a descending order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class DescendingZipOrder : IComparer<Parcel>
    {
        // Precondition:  None
        // Postcondition: Reverses the order, thus making it descending
        //                by destination zip
        public int Compare(Parcel p1, Parcel p2)
        {
            if (p1 == null & p2 == null) // if both values are null
                return 0;// then they are equal 
            if (p1 == null) // if only p1 is null
                return -1; // then null is less than any actual zip
            if (p2 == null)// if only p2 is null
                return 1; // then any zip is greater than null
            return (-1) * p1.DestinationAddress.Zip.CompareTo(p2.DestinationAddress.Zip); // makes the order descending by destination zip

        }        

    }
}
