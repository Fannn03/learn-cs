using System;

namespace Variable {
  class CreateVariable {
    static void Main (string[] args) {
      string name = "Irfan Setiawan";
      int age = 20;
      double money = 150.12;
      char blood = 'o';
      bool isAlive = true;

      Console.WriteLine("My name is " + name);
      Console.WriteLine("I'm " + age + " years old");
      Console.WriteLine(money);
      // C# can override value number
      money = 200.12;
      Console.WriteLine(money);

      // using const to prevent override data
      const string gender = "Male";
      
      Console.WriteLine(gender);
      // gender = "Female" // this will be error
      Console.WriteLine(gender);
    }
  }
}