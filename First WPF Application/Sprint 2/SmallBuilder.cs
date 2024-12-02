using System.Collections.ObjectModel;

class smallBnbBuilder : IBnbBuilder
{
    ObservableCollection<string> BnbFeatures = new ObservableCollection<string>();

    public void buildland()
    {
        BnbFeatures.Add("Small flat (550 square feet)");
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
        BnbFeatures.Add("No garden");
    }
    public void buildFence()
    {
        BnbFeatures.Add("small fence on the front of the flat");
    }
    public ObservableCollection<string> getBNB()
    {
        return this.BnbFeatures;
    }
}