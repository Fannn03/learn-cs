using System;

namespace Program;

sealed class Person {
  public string name = "Using sealed keyword cannot have inheritance class";
}

class Fruits {
  public string PropertyFruit 
  {get; set;}

  public void Fruit () {
    Console.WriteLine("Fruits is juicy");
  }
}

class Apple : Fruits {
  public string name = "apple";
}

class Program {
  static void Main (string[] args) {
    Apple apple = new Apple();
    apple.Fruit();

    Console.WriteLine(apple.name);

    apple.PropertyFruit = "This is property fruits";
    Console.WriteLine(apple.PropertyFruit);
  }
}