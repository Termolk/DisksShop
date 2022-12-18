namespace WaspHomeWork3;

public interface IStoreItem
{
    double Price { get; set; }
    
    void DiscountPrice(int percent)
    {
        Price = (Price - (Price * ((double)percent / 100)));
    }
}