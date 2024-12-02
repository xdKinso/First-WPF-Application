using System.Collections.ObjectModel;

class BnbType : IBnb
{
    private string propertyname;
    private int price;
    private bool reserved = false;
    private string customername;
    private string ownerName;
    private string location;

    private ObservableCollection<IBnb> bnbs = new ObservableCollection<IBnb>();

    public BnbType(string propertyname, ObservableCollection<IBnb> bnbs)
    {
        this.propertyname = propertyname;
            
    }
    public void displayProperty()
    {
        foreach (IBnb bnb in bnbs)
        {
            //Console.WriteLine($"This is the {this.propertyname}");
        }
        
    }
    public void AddBnb(IBnb bnb)
    {
        this.bnbs.Add(bnb);
    }
    public void reserveBnb(string customer)
    {

    }
    public string getPrice()
    {
        return "nothing";
    }
    public string setPrice(int price)
    {
        return "nothing";
    }
    public string setPropertyName(string nameOfProperty)
    {
        return "nothing";
    }
    public string getPropertyName()
    {
        return "nothing";
    }
    public string setOwnerName(string ownerName)
    {
        return ownerName;
    }
    public string getOwnerName()
    {
        return this.ownerName;
    }
    public string unreserve()
    {
        return "unreserved";
    }
    public string getLocation()
    {
        return "nothing";
    }
    public string setLocation(string Location)
    {
        return "nothing";
    }

}