using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestFixture]
    public class TestClass
    {
        List<string> items;
        Basket.Program basket;
        [SetUp]
        public void SetUp()
        {
            items = new List<string>();
            items.Add("omena");
            items.Add("banaani");
            basket = new Basket.Program("Jari", items, 25.0);
        }

        [TearDown]
        public void TearDown()
        {
            items = null;
            basket = null;
        }

        [Test]
        public void IsCustomerString()
        {
            Assert.That(basket.returnCustomer(), Is.InstanceOf(typeof(string)));
        }

        [Test]
        public void IsPriceDouble()
        {
            Assert.That(basket.returnPrice(), Is.InstanceOf(typeof(double)));
        }
        [Test]
        public void IsContentsList()
        {
            Assert.That(basket.returnContents(), Is.InstanceOf(typeof(List<string>)));
        }

        [Test]
        public void AddToContents()
        {
            basket.addProduct("kala", 5.0);
            Assert.That(basket.returnContents(), Contains.Item("kala"));
        }

        [Test]
        public void DeleteFromList()
        {
            basket.deleteProduct("kala", 5.0);
            Assert.That(basket.returnContents(), !Contains.Item("kala"));
        }

        [Test]
        public void CalculateDiscount()
        {
            Assert.That(basket.calculateDiscountPrice(10), Is.EqualTo(22.5));
        }

        [Test]
        public void CalculateAveragePrice()
        {
            Assert.That(basket.calculateAverageItemPrice(), Is.EqualTo(12.5));
        }
    }
}
