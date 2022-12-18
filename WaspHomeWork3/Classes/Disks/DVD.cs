namespace WaspHomeWork3;

public class DVD : Disk
{
    public string Producer { get; set; }
    public string FilmCompany { get; set; }
    public int MinutesCount { get; set; }


    public DVD(string name, string genre, string producer, string filmCompany, int minutesCount)
        : base(name, genre)
    {
        Producer = producer;
        FilmCompany = filmCompany;
        MinutesCount = minutesCount;
    }

    public override int DiskSize { get => (MinutesCount / 64) * 2; }
    
    public override void Burn(params string[] values)
    {
        foreach (string ch in values)
        {
            
        }
        BurnCount++;
    }

    public override string ToString()
    {
        return $"{Name}, {Genre}, {Producer}, {FilmCompany}, {MinutesCount}, {BurnCount}";
    }
}