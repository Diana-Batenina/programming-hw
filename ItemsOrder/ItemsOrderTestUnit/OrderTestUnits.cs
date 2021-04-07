using Microsoft.VisualStudio.TestTools.UnitTesting;
using ItemsOrder;
using System.IO;
using System;

namespace ItemsOrderTestUnit
{
    [TestClass]
    public class OrderTestUnits
    {
        [TestMethod]
        public void ConstructorTestMethod()
        {
            var ikeaTable = CreateTestOrder();
            Assert.AreEqual("Складной стол IKEA", ikeaTable.NameOfItem);
            Assert.AreEqual("IKEA-TABLES-1598764", ikeaTable.VendorCode);
            Assert.AreEqual("Petrov", ikeaTable.CourierSurname);
            Assert.AreEqual((long)100203, ikeaTable.OrderNumber);
            Assert.AreEqual("06.03.2021 15:43:00", ikeaTable.Delivered.ToString());
            Assert.AreEqual(TypesOfOrder.Regular, ikeaTable.OrderType);
        }
        [TestMethod]
        public void ToStringTestMethod()
        {
            var ikeaTable = CreateTestOrder();
            Assert.AreEqual("Складной стол IKEA IKEA-TABLES-1598764", ikeaTable.ToString());
        }
        [TestMethod]
        public void PrintInfoTestMethod()
        {
            
            var ikeaTable = CreateTestOrder();
            var boshWash = new Order("Стиральная машина BOSCH", "BOSCH-WASHING_MACHINES-123456", "Ivanov", 1592874, "16.04.2021 14:17", TypesOfOrder.Urgent);
            var consoleOut = new[] { "Складной стол IKEA IKEA-TABLES-1598764", $"Фамилия курьера: Petrov. Номер заказа: 100203. Дата и время доставки: 06.03.2021 15:43. Тип доставки: обычный.", "Стиральная машина BOSCH BOSCH-WASHING_MACHINES-123456", $"Фамилия курьера: Ivanov. Номер заказа: 1592874. Дата и время доставки: 16.04.2021 14:17. Тип доставки: срочный." };

            
            TextWriter oldOut = Console.Out; 
            StringWriter output = new StringWriter();
            Console.SetOut(output); 
            ikeaTable.PrintInfo();
            boshWash.PrintInfo();
            Console.SetOut(oldOut); 
            var outputArray = output.ToString().Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            
            Assert.AreEqual(4, outputArray.Length);
            for (var i = 0; i < consoleOut.Length; i++)
                Assert.AreEqual(consoleOut[i], outputArray[i]);
        }
        private Order CreateTestOrder()
        {
            return new Order("Складной стол IKEA", "IKEA-TABLES-1598764", "Petrov", 100203, "06.03.2021 15:43", TypesOfOrder.Regular);
        }
    }
}
