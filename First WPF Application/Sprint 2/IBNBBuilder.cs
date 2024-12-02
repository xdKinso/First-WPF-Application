using System.Collections.ObjectModel;

public interface IBnbBuilder
{
    public void buildland();
    public void buildGarden();
    public void buildPool();
    public void buildFence();
    public void reset();
    public ObservableCollection<string> getBNB();

}