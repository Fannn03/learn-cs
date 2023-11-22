using System;

namespace Program;

class Person {
  // can't be accessed in class People
  private string name = "irfan";

  // can be accessed in class people
  public string publicName = "irfan";
}

class People {
  static void Main (string[] args) {
    
    Person person = new Person();

    Console.WriteLine(person.publicName);

  }
}