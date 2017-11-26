//Grading ID : C4811
//Program 4
// CIS 200-01/76
// Due: 11/129/2016

// File: TestParcels.cs
// This is a simple, console application designed to exercise the Parcel hierarchy.
// It creates several different Parcels and prints them. It also sorts the Parcels
// by Cost(Ascending) and Destination Zip (Descending)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class TestParcels
    {
        // Precondition:  None
        // Postcondition: Parcels have been created and displayed
        static void Main(string[] args)
        {
            // Test Data - Magic Numbers OK
            Address a1 = new Address("John Smith", "123 Any St.", "Apt. 45",
                "Louisville", "KY", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.", "",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4

            Letter letter1 = new Letter(a1, a2, 3.95M);                            // Letter test objects (3)
            Letter letter2 = new Letter(a4, a3, 4.00M);
            Letter letter3 = new Letter(a2, a3, 2.00M);
            GroundPackage gp1 = new GroundPackage(a3, a4, 14, 10, 5, 12.5);        // Ground test objects (3)
            GroundPackage gp2 = new GroundPackage(a1, a2, 20, 5, 10, 15.5);
            GroundPackage gp3 = new GroundPackage(a2, a1, 2, 13, 4, 30.5);
            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a3, 25, 15, 15,    // Next Day test objects (2)
                85, 7.50M);
            NextDayAirPackage ndap2 = new NextDayAirPackage(a3, a2, 5, 16, 25, 20.0,15.0M);
            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a4, a1, 46.5, 39.5, 28.0, // Two Day test objects (2)
                80.5, TwoDayAirPackage.Delivery.Saver);
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a3, a1, 50, 20, 35, 25, TwoDayAirPackage.Delivery.Early);

            List<Parcel> parcels;      // List of test parcels

            parcels = new List<Parcel>();

            parcels.Add(letter1); // Adds letter object to the list
            parcels.Add(letter2);// Adds letter object to the list
            parcels.Add(letter3);// Adds letter object to the list
            parcels.Add(gp1);// Adds GroundPackage object to the list
            parcels.Add(gp2);// Adds GroundPackage object to the list
            parcels.Add(gp3);// Adds GroundPackage object to the list
            parcels.Add(ndap1);// Adds NextDayAirPackage object to the list
            parcels.Add(ndap2);// Adds NextDayAirPackage object to the list
            parcels.Add(tdap1);// Adds TwoDayAirPackage object to the list
            parcels.Add(tdap2);// Adds TwoDayAirPackage object to the list

            Console.WriteLine("Original List:");
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }
            Pause();

             //default sort
             // displays all parcels in the lsit by Cost in Ascending order
            parcels.Sort();
            Console.Out.WriteLine("Default Sort, Ascending by Cost");

            foreach (Parcel p in parcels)
               Console.WriteLine(p);

            Pause();

            //descending sort
            //displays all the parcels in the list by Destination Zip in Descending order
            parcels.Sort(new DescendingZipOrder());
            Console.Out.WriteLine("Sorted List, Descending by Destination Zip Code");

            foreach (Parcel p in parcels)
                Console.WriteLine(p);
            Pause();


       }

        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        public static void Pause()
        {
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();

            Console.Clear(); // Clear screen
        }
    }
}
