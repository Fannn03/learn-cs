using System;

namespace Program;

class Person {
  // public field
  public string name;
  // constructor
  public Person (string personName) {
    name = personName;
  }

  private int age;
  // property access private field 'age'
  public int Age {
    get { return age; }
    set { age = value; }
  }

  // property short hand
  public int newAge
  {get; set;}
}

class Program {
  static void Main (string[] args) {
    Person person = new Person("Irfan");
    Console.WriteLine(person.name);

    person.Age = 12;
    Console.WriteLine(person.Age);

    person.newAge = 25;
    Console.WriteLine(person.newAge);
  }
}