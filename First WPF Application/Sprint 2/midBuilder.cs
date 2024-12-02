using System.Collections.ObjectModel;

class midBuilder : IBnbBuilder
{
    ObservableCollection<string> BnbFeatures = new ObservableCollection<string>();

    public void buildland()
    {
        BnbFeatures.Add("Medium flat (1000 square feet) 2 Bed rooms");
    }
    public void reset()
    {
        this.BnbFeatures.Clear();
    }
    public void buildPool()
    {
        BnbFeatures.Add("No pool Available");
    }
    public void buildGarden()
    {
        BnbFeatures.Add("A nice garden");
    }
    public void buildFence()
    {
        BnbFeatures.Add("small fence on the front of the flat and around the garden");
    }
    public ObservableCollection<string> getBNB()
    {
        return this.BnbFeatures;
    }
}