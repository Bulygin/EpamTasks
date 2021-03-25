using Microsoft.VisualStudio.TestTools.UnitTesting;
using EpamTaks;

namespace EpamTaks.Tests {
  [TestClass()]
  public class EpamTests {
    [TestMethod()]
    public void getFactorialTest() {
      Assert.AreEqual(EpamTaks.getFactorial(0), (ulong)1);
      Assert.AreEqual(EpamTaks.getFactorial(1), (ulong)1);
      Assert.AreEqual(EpamTaks.getFactorial(5), (ulong)120);
      Assert.AreEqual(EpamTaks.getFactorial(54), 10519282829630636032);
    }
  }
}

