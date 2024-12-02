using System;
using System.Reflection;

class Customer : Person 
{
    public Customer(string firstName, string lastName, int age, string city,int salary ) : base (firstName, lastName, age, city, salary)
    {
        
    }
    public override string printName()
    {
        return $"Customer: {this.fullName}";
    }
    public string getCustomerDetails()
    {
        return $"Customer: {this.fullName} is {this.age} years old, and is from {this.city}, They earn {this.salary} yearly";
    }
    public void setSalary(int salary)
    {
        this.salary = salary;
        Console.WriteLine("the New salary of " + this.fullName + " is " + this.salary);
    }

}