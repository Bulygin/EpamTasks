using Microsoft.VisualStudio.TestTools.UnitTesting;
using EpamTaks;
using System.Linq;

namespace EpamTaks.Tests {
  [TestClass()]
  public class EpamTests {
    [TestMethod()]
    public void ReverseTest() {
      Assert.AreEqual(EpamTaks.Reverse(new int[] { 0 }).ToArray()[0], 0);
      Assert.AreEqual(EpamTaks.Reverse(new int[] { 1, 2, 3, 4, 5 }).ToArray()[0], 5);
      Assert.AreEqual(EpamTaks.Reverse(new int[] { 1, 2, 3, 4, 5 }).ToArray()[3], 2);
    }
  }
}

