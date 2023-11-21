using System;

namespace Program {
  class Fruits {

    bool isJuicy = true;
    string name = "fruits";
    int addValue;

    // static method can be accessed without creating an object of the class
    private void buyFruits () {
      Console.WriteLine("Buy me some fruits");
    }

    static void Main (string[] args) {

      Fruits fruits = new Fruits();
      Apple apple = new Apple(); // create object from class apple

      fruits.addValue = 12;

      Console.WriteLine($"I Like fruits, because it's juicy {fruits.isJuicy}");
      Console.WriteLine($"Name Fruits {fruits.name}");
      Console.WriteLine($"New Value {fruits.addValue}");

      fruits.buyFruits();

      Console.WriteLine(apple.name);

    }
  }
}