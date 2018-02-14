
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;

namespace Anagram.Models
{
  public class AnagramGenerator
  {
    private string _word;
    private string _listCheck;
    private List<string> _compareWords = new List<string> {};
    private List<string> _wordCharList = new List<string> {};
    private List<List<string>> _splitCompareList = new List<List<string>> {};

    public AnagramGenerator(string newWord, string newListCheck)
    {
      _word = newWord;
      _listCheck = newListCheck;
    }

    public string GetWord()
    {
        return _word;
    }

    public string GetListCheck()
    {
      return _listCheck;
    }

    public List<string> GetCompareList()
    {
        return _compareWords;
    }

    public List<string> GetWordCharList()
    {
      return _wordCharList;
    }

    public List<List<string>> GetSplitCompareList()
    {
      return _splitCompareList;
    }

    public void BreakString()
    {
      string[] separators = {",", " ", "."};
      string[] words = _listCheck.ToString().Split(separators, StringSplitOptions.RemoveEmptyEntries);
      for (int index = 0; index < words.Length; index ++)
      {
          _compareWords.Add(words[index]);
      }
    }
    public void CreateCharList()
    {
      string[] characters = Regex.Split(_word, string.Empty);
      for (int index = 0; index < characters.Length; index ++)
      {
        if (characters[index] !="")
        {
          _wordCharList.Add(characters[index]);
        }
        else
        {

        }
      }
    }
  }
}
