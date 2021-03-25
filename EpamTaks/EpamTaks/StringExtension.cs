using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTaks {
  public static class StringExtension {
    public static string AddSpaceAfterEachChar(this string str) {
      string result = "";
      foreach (char charInStr in str) {
        result += charInStr + " ";
      }
      return result;
    }
  }
}
