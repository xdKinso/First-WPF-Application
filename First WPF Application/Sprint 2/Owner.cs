using System;
using System.Reflection;

class Owner : Person
{
    public Owner(string firstName, string lastName, int age, string city, int salary) : base(firstName, lastName, age, city, salary)
    {

    }
    public override string printName()
    {
        return $"Owner: {this.fullName}";
    }
    public string getOwnerDetails()
    {
        return $"Owner: {this.fullName} is {this.age} years old, and is from {this.city}, They earn £{this.salary} yearly";
    }
    public void setSalary(int salary)
    {
        this.salary = salary;
        Console.WriteLine("the New salary of " + this.fullName + " is " + this.salary);
    }

}