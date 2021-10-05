using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatoriskOpgave1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatoriskOpgave1.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {
        private FootballPlayer _footballPlayer;

        [TestInitialize]
        public void MyTestInitialize()
        {
            _footballPlayer = new FootballPlayer
            {
                Id = 1, Name = "Hans", Price = 20, ShirtNumber = 5
            };
        }
        [TestMethod()]
        public void NameTest()
        {
            _footballPlayer.Name = "Nikolaj";
            Assert.AreEqual("Nikolaj", _footballPlayer.Name);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _footballPlayer.Name = "Bo");
        }

        [TestMethod()]
        public void PriceTest()
        {
            _footballPlayer.Price = 0.1;
            Assert.AreEqual(0.1, _footballPlayer.Price);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _footballPlayer.Price = 0);
        }

        [TestMethod()]
        public void ShirtNumberTest()
        {
            _footballPlayer.ShirtNumber = 100;
            Assert.AreEqual(100, _footballPlayer.ShirtNumber);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _footballPlayer.ShirtNumber = 0);
        }

        [TestMethod()]
        public void IdTest()
        {
            Assert.AreEqual(1, _footballPlayer.Id);
        }
    }
}