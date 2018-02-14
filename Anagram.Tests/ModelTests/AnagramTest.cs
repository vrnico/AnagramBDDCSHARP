
using System.Collections.Generic;
using System.Text.RegularExpressions;

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

    [TestMethod]
    public void SeperateListCheck_ReturnNewList()
    {
      string word = "evil";
      string listCheck = "big boy";
      List<string> test = new List<string> {"big", "boy"};
    AnagramGenerator newAnagramGenerator = new AnagramGenerator(word, listCheck);

    newAnagramGenerator.BreakString();
    List<string> newList = new List<string> {};
    newList = newAnagramGenerator.GetCompareList();

    CollectionAssert.AreEqual(newList, test);
    }

    [TestMethod]
    public void BreakWordIntoChar_ReturnCharList()
    {
      string word = "evil";
      string listCheck = "big boy";
      List<string> charList = new List<string> { "e", "v", "i", "l"};
      AnagramGenerator newAnagramGenerator = new AnagramGenerator (word, listCheck);

      List<string> newList = new List<string> {};
      newAnagramGenerator.CreateCharList();
      newList = newAnagramGenerator.GetWordCharList();

      CollectionAssert.AreEqual(charList, newList);

    }

    [TestMethod]
    public void BreakListIntoCharList_ReturnListofCharLists()
    {
      string word = "evil";
      string listCheck = "big boy";
      Assert.AreEqual(word, listCheck);
    }
  }
}
