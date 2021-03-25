using System;
using System.Collections.Generic;

namespace EpamTaks {
  public class EpamTaks {
    static void Main(string[] args) {
    }
    public static string[] getWordsOnLetter(string text, char letter) {
      List<string> result = new List<string>();
      foreach (string word in text.Split(' ')) {
        if (char.ToLower(word[0]) == char.ToLower(letter)) {
          result.Add(word);
        }
      }
      return result.ToArray();
    }
  }
}
