using System;

namespace ItemsOrder
{
    public class Order
    {
        public string NameOfItem;
        public readonly string VendorCode;
        public string CourierSurname;

        public readonly long OrderNumber;
        public DateTime Delivered;
        public TypesOfOrder OrderType;
        public Order(string nameOfItem, string vendorCode, string courierSurname, long orderNumber, string delivered, TypesOfOrder orderType)
        {
            NameOfItem = nameOfItem;
            VendorCode = vendorCode;
            CourierSurname = courierSurname;
            OrderNumber = orderNumber;
            Delivered = DateTime.Parse(delivered);
            OrderType = orderType;
        }
        public override string ToString()
        {
            return $"{NameOfItem} {VendorCode}";
        }
        public void PrintInfo()
        {
            Console.WriteLine(this);

            var orderType = "";
            switch (OrderType)
            {
                case TypesOfOrder.Regular:
                    orderType = "обычный";
                    break;
                case TypesOfOrder.Urgent:
                    orderType = "срочный";
                    break;
            }

            Console.WriteLine($"Фамилия курьера: {CourierSurname}. Номер заказа: {OrderNumber}. Дата и время доставки: {Delivered.ToShortDateString()} {Delivered.ToShortTimeString()}. Тип доставки: {orderType}.");
        }

    }
    
}
