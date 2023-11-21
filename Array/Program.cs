using System;

namespace Array {
  class ArrayProgram {
    static void Main (string[] args) {
      string[] people = ["irfan", "torik", "apeep", "ara"];
      string[] cars = new string[3] {"BMW", "Volvo", "Ford"};
      int[] age = {1, 2, 3, 5};

      foreach (string i in cars) {
        Console.WriteLine(i);
      }

      // Multi dimension array
      int[,] cash = {{1, 3, 2, 5}, {9, 6, 8, 2}};
      foreach (int i in cash) {
        Console.WriteLine(i);
      }
    }
  }
}