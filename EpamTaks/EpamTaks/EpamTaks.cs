using System;

namespace EpamTaks {
  public class EpamTaks {
    static void Main(string[] args) {
    }
    public static ulong getFactorial(ulong num) {
      if (num == 0) return 1;
      return getFactorial(num - 1) * num;
    }
  }
}
