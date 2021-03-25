using Microsoft.VisualStudio.TestTools.UnitTesting;
using EpamTaks;

namespace EpamTaks.Tests {
  [TestClass()]
  public class EpamTests {
    [TestMethod()]
    public void getWordsOnLetterTest() {
      Assert.AreEqual(EpamTaks.getWordsOnLetter("Test text with different words", 't')[0], "Test");
      Assert.AreEqual(EpamTaks.getWordsOnLetter("Test text with different words", 'T')[0], "Test");
    }
  }
}

