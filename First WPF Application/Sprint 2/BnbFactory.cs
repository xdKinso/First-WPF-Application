using System.Text.RegularExpressions;

public class BnbFactory
{
    public IBnb MakeBnb(string type, string name, int price, string owner, string location)
    {
        if (type == "Small")
        {
            //Console.WriteLine("A small BNB has been created for you Thankyou,", name);
            return new smallBNB(name, price, owner, location);
            
        }
        else if (type == "Medium")
        {
            //Console.WriteLine("A medium BNB has been created for you Thankyou,", name);
            return new mediumBNB(name, price, owner, location);
        }
        else if (type == "Big")
        {
           // Console.WriteLine("A big BNB has been created for you Thankyou,", name);
            return new bigBNB(name, price, owner, location);
        }
        else if (type == "Villa")
        {

            //Console.WriteLine("A Villa BNB has been created for you Thankyou,", name);
            return new villaBNB(name, price, owner, location);
        }
        else
        {
            //.WriteLine("could not create a BNB of type,", type);
            return null;
        }
    }
}