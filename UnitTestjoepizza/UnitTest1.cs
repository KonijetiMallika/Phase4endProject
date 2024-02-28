using JoesLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestjoepizza
{
    [TestClass]
    public class UnitTest1
    {
        Pizza p = new Pizza();

        [TestMethod]
        public void Test1()
        {
            //Assign or Arrange
            int pid = 101;
            string ptype = "Chicken Pizza";

            //Act
            string acname = p.display(101);

            //Assert

            Assert.AreEqual(ptype, acname);
        }
        [TestMethod]
        public void Test2()
        {

            //Assign or Arrange
            int pid = 102;
            string ptype = "Margherita";

            //Act
            string acname = p.display(102);

            //Assert

            Assert.AreEqual(ptype, acname);
        }
        [TestMethod]
        public void Test3()
        {
            //Assign or Arrange
            int pid = 102;
            string ptype = "Margherita";

            //Act
            string acname = p.display(102);

            //Assert

            Assert.AreEqual(ptype, acname);
        }

    }
}
