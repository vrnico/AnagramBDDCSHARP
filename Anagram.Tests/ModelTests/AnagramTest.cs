using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram;

namespace Anagram.Tests
{
  [TestClass]
  public class AnagramTest
  {
    [TestMethod]
    public void Anagram_SetWord_ReturnWord()
    {
      AnagramGenerator testAnagram = new AnagramGenerator();
      Assert.AreEqual("evil", testAnagram.Anagram("evil"));


    }
  }
}
