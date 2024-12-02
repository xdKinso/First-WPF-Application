using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

class mediumBNB : IBnb
{
    //properties of the bnb
    private string propertyName;
    private int price;
    private bool reserved = false;
    private string customername;
    private string ownerName;
    private string location;

    public mediumBNB(string nameOfProperty, int price, string ownerName, string location)
    {
        this.propertyName = nameOfProperty;
        this.price = price;
        this.ownerName = ownerName;
        this.location = location;
    }
    public void reserveBnb(string customername)
    {
        if (this.reserved == true)
        {
            //Console.WriteLine($"{this.propertyName} is Already reserved ");
        }
        else
        {
            this.customername = customername;
            this.reserved = true;
            //Console.WriteLine(this.propertyName + " Is now reserved by " + this.customername);
        }
    }
    public void displayProperty()
    {
        //Console.WriteLine("Is the property reserved: " + this.reserved);
        //Console.WriteLine($"I am a {this.GetType()}");
        //Console.WriteLine($"The property {this.propertyName}, Is set at a price of {this.price}, It is located in {this.location}, It is owned by {this.ownerName}");
    }
    public string getPrice()
    {
        return $"The price is {this.price}";
    }
    public string setPrice(int price)
    {
        this.price = price;
        return $"The price is now {this.price}";
    }

    public string setPropertyName(string propertyName)
    {
        this.propertyName = propertyName;
        return $"{this.propertyName}";
    }
    public string getPropertyName()
    {
        return $"{this.propertyName}";
    }
    public string setOwnerName(string ownerName)
    {
        this.ownerName = ownerName;
        return $"The owner is now {this.ownerName}";
    }
    public string getOwnerName()
    {
        return $"The owner is {this.ownerName}";
    }
    public string unreserve()
    {
        if (this.reserved == false)
        {
            return $"{this.propertyName} is already Unreserved";
        }
        else if (this.reserved == true)
        {
            this.reserved = false;
            return $"The property {this.propertyName} is now unreserved";
        }
        return "Thankyou";

    }
    public string getLocation()
    {
        return this.location;
    }
    public string setLocation(string Location)
    {
        this.location = Location;
        return $"This location is now {this.location}";
    }
}