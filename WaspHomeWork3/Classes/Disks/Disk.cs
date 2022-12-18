namespace WaspHomeWork3;

public class Disk : IStoreItem
{
    private string _name;
    private string _genre;
    private int _burnCount;

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public string Genre
    {
        get => _genre;
        set => _genre = value;
    }
    
    public int BurnCount
    {
        get => _burnCount;
        protected set => _burnCount = value;
    }
    
    

    public Disk(string name, string genre)
    {
        Name = name;
        Genre = genre;
    }
    
    public virtual int DiskSize { get; }

    public virtual void Burn(params string[] values)
    {
        
    }

    public double Price { get; set; }
    
    public void DiscountPrice(int percent)
    {
        Price = (Price - (Price * ((double)percent / 100)));
    }
    
}