using Microsoft.Win32.SafeHandles;
using System.Collections.ObjectModel;
using System.Windows.Automation.Peers;

class Bnb
{
    private static Bnb BnbInstance = null;
    private ObservableCollection<IBnb> bnbs = new ObservableCollection<IBnb>();
    //factory class ready
    private BnbFactory bnbfactory = new BnbFactory();
    

    private Bnb()
    {
        Owner ow1 = new Owner("krystian", "Mowinski", 19, "London", 40000);
        Customer cus1 = new Customer("Anna", "Czochara", 20, "Przemysl", 80000);
        smallBNB sBnb1 = new smallBNB("Mowinski Residence", 10000, ow1.fullName, "london");
        villaBNB vBnb1 = new villaBNB("Czochara Residence", 30000, "Anna Czochara", "Przemysl");
        mediumBNB mBnb1 = new mediumBNB("Mickiewicz Residence",15000, "Szymon Mickiewicz", "Egham");
        bigBNB bBnb1 = new bigBNB("House Residence", 25000, "Gregory House", "USA");
        bnbs.Add(sBnb1);
        bnbs.Add(vBnb1);
        bnbs.Add(mBnb1);
        bnbs.Add(bBnb1);
       

    }
    public static Bnb getInstance()
    {
        if (BnbInstance == null)
        {
            BnbInstance = new Bnb();
        }
        return BnbInstance;
    }
    public void addBnb(string type, string name, int price, string owner, string location)
    {
        this.bnbs.Add(this.bnbfactory.MakeBnb(type, name, price, owner, location));
    }
    public void viewBnb()
    {
        //Console.WriteLine("Property name             Price               Location              Owner Name     ");
        int i = 0;
        foreach (var item in bnbs)
        {
            i++;
            //Console.WriteLine($"{i})Property Name: {item.getPropertyName()} |Property Price: {item.getPrice()} |Property Location: {item.getLocation()} |Owner: {item.getOwnerName()}");
        }

    }
    public void reservebnb(int choice, string customerName)
    {
        choice = (choice - 1);
        //bnbs.ElementAt(choice).reserveBnb(customerName);
    }
    public void unreservebnb(int choice)
    {
        choice = choice - 1;
        //bnbs.ElementAt(choice).unreserve();
    }
    public void modifyBnb(int choice, string value,int bnbnum)
    {
        bnbnum = bnbnum - 1;
        if (choice == 1)
        {
            //bnbs.ElementAt(bnbnum).setPrice(Convert.ToInt32(value));
        }
        else if(choice == 2)
        {
            //bnbs.ElementAt(bnbnum).setPropertyName(value);
        }
        else if(choice == 3)
        {
            //bnbs.ElementAt(bnbnum).setOwnerName(value);
        }
        else if(choice == 4)
        {
            //bnbs.ElementAt(bnbnum).setLocation(value);
        }
    }
    
}