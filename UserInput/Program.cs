using System;

namespace UserInput {
  class UserInputProgram {
    static void Main (string[] args) {
      // will give warning if input value is null
      Console.Write("Enter your name : ");
      string name = Console.ReadLine();

      Console.Write("Enter your Age : ");
      int age = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Your name : " + name);
      Console.WriteLine("Your age : " + age);
    }
  }
}