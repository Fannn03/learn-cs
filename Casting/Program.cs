using System;

namespace Casting {
  class Casting {
    static void Main (string[] args) {
      // Implicit casting > automatic casting
      int age = 20;
      double myAge = age;

      Console.WriteLine(age);
      Console.WriteLine(myAge);

      double yourAge = 9.12;
      int mineAge = yourAge;

      Console.WriteLine(yourAge);
      Console.WriteLine(mineAge);
    }
  }
}