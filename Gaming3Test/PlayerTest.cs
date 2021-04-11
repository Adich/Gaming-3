using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Gaming_3;

namespace Gaming3Test
{
    [TestClass]
    public class PlayerTest
    {
        [TestMethod]
        public void TakeDmgTest()
        {
            //Arrange
            string name = "Adich";

            //Act
            Player player = new Player(name);

            //Assert
            Assert.AreEqual(player.Name, name);
        }
    }
}
