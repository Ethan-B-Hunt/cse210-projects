using System;
using System.Dynamic;
using System.Security.Cryptography;

class Program
{
    void Main(string[] args)
    {
        Person person = new Person("John", 32);
        Console.WriteLine(person);
    }
}
class Person {
    public string Name { get; set; }

    public int Age { get; set; }

    public Person(string name, int age){
        Name = name;
        Age = age;
    }
}