using Assignment_5.Class;

namespace Assignment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //1 -
            //a) What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?
            //A: a new copy of the object will be created on the stack, and only the new copy will be modified.

            //b)  What happens when a Customer variable is copied into another variable and one variable modifies the object
            //A: No new object is created.Both variables reference the same object in memory.Therefore, when one variable modifies the object, the changes are visible through the other variable as well.

            #endregion

            #region Question02
            //2-
            //a) Identify at least three problems with this design from an encapsulation perspective.
            //A: -The fields are public, which breaks encapsulation.
            //   -There is no validation for the data.
            //   -The struct does not use properties to control access to its data.

            //b) How can private fields and public properties improve this design?
            //A: -Private fields hide the data from direct access.
            //   -Public properties control access to the data.
            //   -Properties can validate values before storing them.
            #endregion

            #region Question03
       
            DeliveryCenter center = new DeliveryCenter();

            Console.WriteLine("Enter Shipment 1 Data");

            Console.Write("Tracking Code: ");
            string trackingCode1 = Console.ReadLine();

            Console.Write("Description: ");
            string description1 = Console.ReadLine();

            Console.Write("Weight: ");
            double weight1 = double.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal fee1 = decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string city1 = Console.ReadLine();

            Console.Write("Street: ");
            string street1 = Console.ReadLine();

            Console.Write("Building Number: ");
            int building1 = int.Parse(Console.ReadLine());

            DeliveryAddress address1 =
                new DeliveryAddress(city1, street1, building1);

            Shipment shipment1 =
                new Shipment(
                    trackingCode1,
                    description1,
                    weight1,
                    fee1,
                    address1
                );

            if (center.AddShipment(shipment1))
            {
                Console.WriteLine("Shipment added successfully.");
            }


           
            Console.WriteLine("Enter Shipment 2 Data");

            Console.Write("Tracking Code: ");
            string trackingCode2 = Console.ReadLine();

            Console.Write("Description: ");
            string description2 = Console.ReadLine();

            Console.Write("Weight: ");
            double weight2 = double.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal fee2 = decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string city2 = Console.ReadLine();

            Console.Write("Street: ");
            string street2 = Console.ReadLine();

            Console.Write("Building Number: ");
            int building2 = int.Parse(Console.ReadLine());

            DeliveryAddress address2 =
                new DeliveryAddress(city2, street2, building2);

            Shipment shipment2 =
                new Shipment(
                    trackingCode2,
                    description2,
                    weight2,
                    fee2,
                    address2
                );

            if (center.AddShipment(shipment2))
            {
                Console.WriteLine("Shipment added successfully.");
            }


            Console.WriteLine("\nEnter Shipment 3 Data");

            Console.Write("Tracking Code: ");
            string trackingCode3 = Console.ReadLine();

            Console.Write("Description: ");
            string description3 = Console.ReadLine();

            Console.Write("Weight: ");
            double weight3 = double.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal fee3 = decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string city3 = Console.ReadLine();

            Console.Write("Street: ");
            string street3 = Console.ReadLine();

            Console.Write("Building Number: ");
            int building3 = int.Parse(Console.ReadLine());

            DeliveryAddress address3 =
                new DeliveryAddress(city3, street3, building3);

            Shipment shipment3 =
                new Shipment(
                    trackingCode3,
                    description3,
                    weight3,
                    fee3,
                    address3
                );

            if (center.AddShipment(shipment3))
            {
                Console.WriteLine("Shipment added successfully.");
            }



            Console.WriteLine("--- All Shipments ---");

            center[0].PrintShipment();
            center[1].PrintShipment();
            center[2].PrintShipment();


            Console.Write("\nEnter a tracking code to search: ");
            string searchCode = Console.ReadLine();

            Shipment result = center[searchCode];

            if (!string.IsNullOrWhiteSpace(result.TrackingCode))
            {
                Console.WriteLine(
                    $"Shipment found: {result.TrackingCode} - {result.Description}"
                );
            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }


            Console.WriteLine("--- Struct Copy Test ---");

            DeliveryAddress originalAddress =
                new DeliveryAddress("Cairo", "Tahrir Street", 15);

            DeliveryAddress copiedAddress = originalAddress;

            copiedAddress.Street = "Makram Ebeid Street";
            copiedAddress.BuildingNumber = 20;

            Console.WriteLine(
                $"Original Address: {originalAddress.GetFullAddress()}"
            );

            Console.WriteLine(
                $"Copied Address: {copiedAddress.GetFullAddress()}"
            );
            #endregion
        }
    }
}
