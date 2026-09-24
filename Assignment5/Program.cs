using System;
using System.Runtime.CompilerServices;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //1st answer
            //a)Both variables end up pointing to the exact same object in the computer's memory. Think of it like having two house keys that open the exact same front door
            //b)No.It only copies the address(reference) of the original object, not the object itself
            //c)Copying a reference means two variables point to one shared object (change one, and the other changes too).

            //Copying an object creates a brand-new, independent clone in memory, so changes to one do not affect the other.
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
