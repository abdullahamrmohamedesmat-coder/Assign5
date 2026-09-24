using System;
using System.Runtime.CompilerServices;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //01st answer
            //a)Both variables end up pointing to the exact same object in the computer's memory. Think of it like having two house keys that open the exact same front door
            //b)No.It only copies the address(reference) of the original object, not the object itself
            //c)Copying a reference means two variables point to one shared object (change one, and the other changes too).

            //Copying an object creates a brand-new, independent clone in memory, so changes to one do not affect the other.
            #endregion

            #region Question 2
            //02 answer
            //a)A quick copy where the main object is duplicated, but any nested objects (like another object inside it) are only copied by their addresses
            //b)A thorough copy where the main object and all of its nested objects are completely duplicated into brand-new, independent copies
            //c)They share the same memory address. If you change a nested object in the copy, it accidentally changes in the original too
            //d)Brand-new copies of the nested objects are created. They are completely independent of the original
            //e)When editing a user profile's address. If you use a shallow copy, changing the copied address might accidentally change the original database record
            //A deep copy keeps them separate and safe
            #endregion

            #region Question 3
            //03 answer
            //a)A static field belongs to the class itself (shared by all objects of that class).
            //An instance field belongs to a specific object(each object has its own separate copy)
            //b)It is a method that belongs to the class, not to any specific object. No, it cannot directly access instance members because it doesn't know which object's data to look at
            //c)A special setup block used to initialize static data. It runs automatically only once, right before the class is used for the very first time
            //d)A class that only contains static tools and helpers. No, you cannot create an object (new) from a static class
            #endregion
            #region Practical Question
            //practical Question
            DeliveryAddress deliveryAddress = new DeliveryAddress("Cairo", "Abbas", 43);
            StandardShipment standardShipment01 = new StandardShipment("TER-343", "Cloths", 23, 5343, deliveryAddress);
            StandardShipment standardShipment02 = standardShipment01;
            standardShipment01.PrintShipment();
            standardShipment02.PrintShipment();
            DeliveryUtilities.PrintSeparator();
            DeliveryUtilities.PrintSystemTitle();

            standardShipment02.Description = "Cars";
            standardShipment01.PrintShipment();
            standardShipment02.PrintShipment();
            DeliveryUtilities.PrintSeparator();
            DeliveryUtilities.PrintSystemTitle();
            Console.WriteLine(StandardShipment.TotalShipmentsCreated);

            StandardShipment standardShipment03 = standardShipment01.ShallowCopy();
            standardShipment01.PrintShipment();
            standardShipment03.PrintShipment();
            DeliveryUtilities.PrintSeparator();
            standardShipment03.Destination.City = "Giza";
            standardShipment01.PrintShipment();
            standardShipment03.PrintShipment();
            Console.WriteLine("-------------------------------");
            Console.WriteLine(StandardShipment.TotalShipmentsCreated);

            StandardShipment standardShipment04 = standardShipment01.DeepCopy();
            standardShipment01.PrintShipment();
            standardShipment04.PrintShipment();
            Console.WriteLine("------------------------------------");
            standardShipment04.Destination.City = "Giza";
            standardShipment01.PrintShipment();
            standardShipment04.PrintShipment();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(StandardShipment.TotalShipmentsCreated);
            Console.WriteLine(StandardShipment.GetTotalShipmentsCreated());
            Console.WriteLine(ShipmentExtensions.GetSummary(standardShipment04));
            Console.WriteLine(ShipmentExtensions.IsDelivered(standardShipment04));

            StandardShipment standard = new StandardShipment("TER-343", "Cloths", 23, 5343, deliveryAddress);

        } 
        #endregion
    }
}
