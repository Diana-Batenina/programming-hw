using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    public class Order
    {
        public string ProductName;
        public readonly string Articulus;
        public string CourierSurname;

        public readonly int ApplicationNumber;
        public DateTime DeliveryDateAndTime;
        public ApplicationType AppType;

        public Application(string name, string articulus, string courier, string number, string deliveryDateTime, ApplicationType appType)
        {
            ProductName = name;
            Articulus = articulus;
            CourierSurname = courier;
            ApplicationNumber = int.Parse(number);
            DeliveryDateAndTime = DateTime.Parse(deliveryDateTime);
            AppType = appType;
        }

        public override string ToString()
        {
            return $"{ProductName}, {Articulus}";
        }

        public void PrintInfo()
        {
            Console.WriteLine(this);

        }
    }
}
