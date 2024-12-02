using System.Collections.ObjectModel;

class BnbDirector
{
    private IBnbBuilder bnbBuilder;
    public BnbDirector(IBnbBuilder builderType)
    {
        this.bnbBuilder = builderType;
    }
    public ObservableCollection<string> makeSmallBnb()
    {
        this.bnbBuilder.buildland();
        this.bnbBuilder.buildGarden();
        this.bnbBuilder.buildPool();
        this.bnbBuilder.buildFence();
        return this.bnbBuilder.getBNB();

    }
    public ObservableCollection<string> makeMidBnb()
    {
        this.bnbBuilder.buildland();
        this.bnbBuilder.buildGarden();
        this.bnbBuilder.buildPool();
        this.bnbBuilder.buildFence();
        return this.bnbBuilder.getBNB();
    }
    public ObservableCollection<string> makeBigBnb()
    {
        this.bnbBuilder.buildland();
        this.bnbBuilder.buildGarden();
        this.bnbBuilder.buildPool();
        this.bnbBuilder.buildFence();
        return this.bnbBuilder.getBNB();
    }
    public ObservableCollection<string> makeVillaBnb()
    {
        this.bnbBuilder.buildland();
        this.bnbBuilder.buildGarden();
        this.bnbBuilder.buildPool();
        this.bnbBuilder.buildFence();
        return this.bnbBuilder.getBNB();
    }
}