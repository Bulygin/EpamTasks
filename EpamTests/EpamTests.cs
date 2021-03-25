using Microsoft.VisualStudio.TestTools.UnitTesting;
using EpamTaks;

namespace EpamTaks.Tests {
  [TestClass()]
  public class EpamTests {
    [TestMethod()]
    public void AddSpaceAfterEachCharTest() {
      Assert.AreEqual("".AddSpaceAfterEachChar(), "");
      Assert.AreEqual("TestString".AddSpaceAfterEachChar(), "T e s t S t r i n g ");
      Assert.AreEqual("Test String".AddSpaceAfterEachChar(), "T e s t   S t r i n g ");
      Assert.AreEqual("Test\nString".AddSpaceAfterEachChar(), "T e s t \n S t r i n g ");
    }
  }
}

