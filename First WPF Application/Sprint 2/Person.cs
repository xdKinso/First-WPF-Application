using System;
using System.Reflection;
using System.Runtime.ExceptionServices;

abstract class Person
{
    protected string firstName;
    protected string lastName;
    public string fullName;
    protected int age;  
    protected string city;
    protected int salary;
    public Person(string firstname, string lastName, int age, string city, int salary)
    {
        this.firstName = firstname;
        this.lastName = lastName;
        this.age = age;
        this.city = city;
        this.fullName = this.firstName + " " + this.lastName;
        this.salary = salary;    
    }
    public virtual string printName()
    {
        return $"Person: {this.fullName}";
    }
    public virtual string printDetails()
    { 
        return $"Person: {this.fullName}  {this.age}  {this.city}";
    }

}