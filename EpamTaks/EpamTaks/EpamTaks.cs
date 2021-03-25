using System;
using System.Collections.Generic;
using System.Linq;

namespace EpamTaks {
  public class EpamTaks {
    static void Main(string[] args) {
    }
    public static IEnumerable<int> Reverse(int[] array) {
      for (int i = array.Length - 1; i >= 0; i--)
        yield return array[i];
    }

  }
}
