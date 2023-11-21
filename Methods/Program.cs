using System;

namespace Program {
  class MethodProgram {
    // Method with return value
    static string CallMyName (string args) {
      return $"Hello my name {args}";
    }

    // Method without return value
    static void MyAge (int args) {
      Console.WriteLine($"My age {args}");
    }

    // Named arguments
    static void NamedArguments (string args1 = "empty", string args2 = "empty") {
      Console.WriteLine($"Args 1 : {args1}, and arg 2 : {args2}");
    }

    // Overload method
    static int Sum(int number1, int number2) {
      return number1 + number2;
    }
    static double Sum(double number1, double number2) {
      return number1 + number2;
    }

    static void Main (string[] args) {
      Console.WriteLine(CallMyName("Irfan"));

      MyAge(12);

      NamedArguments();
      NamedArguments("Pantek");
      NamedArguments(args2: "First", args1: "Last");

      Console.WriteLine(Sum(3, 3));
      Console.WriteLine(Sum(3.1, 3.3));
    }
  }
}