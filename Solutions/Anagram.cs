// https://exercism.org/tracks/csharp/exercises/anagram

using System;
using System.Linq;
using System.Collections.Generic;

public class Anagram
{
    private string _baseWord;
    public Anagram(string baseWord)
    {
        this._baseWord = baseWord.ToLower();
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        List<string> matches = new List<string>();
        foreach(string _word in potentialMatches)
        {                
            string word = _word.ToLower();
            
            if(word == _baseWord)
                continue;
            if(word.Length != _baseWord.Length)
                continue;
            
            List<char> _baseWordArr = _baseWord.ToCharArray().ToList();
                
          foreach(char l in word.ToCharArray())
          {
              if(!_baseWordArr.Contains(l))
                  break;
              _baseWordArr.Remove(l);
          };
            if(_baseWordArr.Count == 0)
                matches.Add(_word);
        };
        return matches.ToArray();
    }
}
