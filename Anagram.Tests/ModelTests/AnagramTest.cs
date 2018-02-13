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
      string word = "evil";
      string listCheck = "big boy";

      AnagramGenerator newAnagramGenerator = new AnagramGenerator(word, listCheck);

      string newWord = newAnagramGenerator.GetWord();
      string newListCheck = newAnagramGenerator.GetListCheck();

      Assert.AreEqual(word, newWord);
      Assert.AreEqual(listCheck, newListCheck);

    }
  }
}
