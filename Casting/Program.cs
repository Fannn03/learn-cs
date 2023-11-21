using System;

namespace Casting {
  class Casting {
    static void Main (string[] args) {
      // Implicit casting > automatic casting > convert from smaller to larger
      int age = 20;
      double myAge = age;

      Console.WriteLine(age);
      Console.WriteLine(myAge);

      // Explicit casting > manual casting > convert from larger to smaller
      double yourAge = 9.12;
      int mineAge = (int) yourAge;
      char charAge = (char) mineAge;

      Console.WriteLine(yourAge);
      Console.WriteLine(mineAge);
      Console.WriteLine(charAge);
    }
  }
}