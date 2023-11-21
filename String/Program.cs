using System;

namespace String {
  class StringProgram {
    static void Main (string[] args) {
      const string name = "Irfan Setiawan";

      Console.WriteLine(name);
      Console.WriteLine(name.Length);
      Console.WriteLine(name.ToUpper());

      // String interpolation same as string format text in javascript, add '$' before double quote
      Console.WriteLine($"My Name is {name}");
      Console.WriteLine(name[1]); // will print r
      Console.WriteLine(name.IndexOf("a")); // will print 3, cause they will find first index character
      Console.WriteLine(name.Substring(name.IndexOf("S")));
    }
  }
}