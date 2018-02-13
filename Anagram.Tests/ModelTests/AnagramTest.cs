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
      AnagramGenerator newAnagramGenerator = new AnagramGenerator(word);
      string newWord = newAnagramGenerator.GetWord();

      Assert.AreEqual(word, newWord);

    }
  }
}
