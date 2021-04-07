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
            Assert.AreEqual("�������� ���� IKEA", ikeaTable.NameOfItem);
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
            Assert.AreEqual("�������� ���� IKEA IKEA-TABLES-1598764", ikeaTable.ToString());
        }
        [TestMethod]
        public void PrintInfoTestMethod()
        {
            
            var ikeaTable = CreateTestOrder();
            var boshWash = new Order("���������� ������ BOSCH", "BOSCH-WASHING_MACHINES-123456", "Ivanov", 1592874, "16.04.2021 14:17", TypesOfOrder.Urgent);
            var consoleOut = new[] { "�������� ���� IKEA IKEA-TABLES-1598764", $"������� �������: Petrov. ����� ������: 100203. ���� � ����� ��������: 06.03.2021 15:43. ��� ��������: �������.", "���������� ������ BOSCH BOSCH-WASHING_MACHINES-123456", $"������� �������: Ivanov. ����� ������: 1592874. ���� � ����� ��������: 16.04.2021 14:17. ��� ��������: �������." };

            
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
            return new Order("�������� ���� IKEA", "IKEA-TABLES-1598764", "Petrov", 100203, "06.03.2021 15:43", TypesOfOrder.Regular);
        }
    }
}
