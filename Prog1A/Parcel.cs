// Program 4
// CIS 200-01
// Due: 11/29/2016
// Grading ID: C4811

// File: Parcel.cs
// Parcel serves as the abstract base class of the Parcel hierachy. also implements the IComparable interface
// as well as creates a Compare method to allow parcels to be sorted by Cost in Ascending order

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Parcel : IComparable<Parcel>
{
    // Precondition:  None
    // Postcondition: The parcel is created with the specified values for
    //                origin address and destination address
    public Parcel(Address originAddress, Address destAddress)
    {
        OriginAddress = originAddress;
        DestinationAddress = destAddress;
    }

    public Address OriginAddress
    {
        // Precondition:  None
        // Postcondition: The parcel's origin address has been returned
        get;

        // Precondition:  None
        // Postcondition: The parcel's origin address has been set to the
        //                specified value
        set;
    }

    public Address DestinationAddress
    {
        // Precondition:  None
        // Postcondition: The parcel's destination address has been returned
        get;

        // Precondition:  None
        // Postcondition: The parcel's destination address has been set to the
        //                specified value
        set;
    }
    // Precondition:  None
    // Postcondition: sorts the pracels in Ascending order by Cost
    public int CompareTo(Parcel p2)
    {
        if (p2 == null)// if only p2 is null
            return 1;//  then any actual cost is greater than null

        if (this.CalcCost().CompareTo(p2.CalcCost()) !=0) // if they are not the same

            return this.CalcCost().CompareTo(p2.CalcCost()); // sort in ascending order by cost
        else
            return 0;// they are equal
    }

    // Precondition:  None
    // Postcondition: The parcel's cost has been returned
    public abstract decimal CalcCost();

    // Precondition:  None
    // Postcondition: A String with the parcel's data has been returned
    public override String ToString()
    {
        return String.Format("Origin Address:{3}{0}{3}{3}Destination Address:{3}{1}{3}Cost: {2:C}",
            OriginAddress, DestinationAddress, CalcCost(), Environment.NewLine);
    }
}
