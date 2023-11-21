using System;

namespace School {
  class School {
    static void Main (string[] args) {
      
      Class class1 = new Class("Rekayasa Perangkat Lunak");

      // Class class1 = new Class();
      // class1.major = "Rekayasa Perangkat Lunak";

      Class class2 = new Class("Teknisi komputer dan jaringan");
      // Class class2 = new Class();
      // class2.major = "Teknisi Komputer dan Jaringan";

      Student student = new Student("Irfan Setiawan");

      Console.WriteLine(class1.major);

      Console.WriteLine(class2.major);

      Console.WriteLine(student.name);

    }
  }
}