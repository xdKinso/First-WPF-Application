//creating an interface for all the possible AirBNB
public interface IBnb
{
    //a method where you can reserve air bnb, changes the customer name and reserved to true
    public void reserveBnb(string customer);
    //display all possible info on the bnb
    public void displayProperty();
    
    //get the price of the bnb 
    public string getPrice();
    //set the price of the bnb
    public string setPrice(int price);
    //set name of the BNB
    public string setPropertyName(string nameOfProperty);
    //get the propery name of the BNB
    public string getPropertyName();

    public string setOwnerName(string ownerName);
    public string getOwnerName();

    public string unreserve();

    public string getLocation();
    public string setLocation(string location);

}
