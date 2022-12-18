namespace WaspHomeWork3;

public class Store
{
    public string StoreName { get; set; }
    public string Address { get; set; }

    private List<Audio> _audios = new List<Audio>();
    private List<DVD> _dvds = new List<DVD>();

    public List<DVD> Dvds { get; set; }
    public List<Audio> Audios { get; set; }
    
    

    public Store(string storeName, string address)
    {
        StoreName = storeName;
        Address = address;
    }
    
    
    public static List<Audio> operator +(Store store, Audio audio)
    {
        store._audios.Add(audio); 
        return store._audios; 
    }
    
    public static List<Audio> operator -(Store store, Audio audio)
    {
        store._audios.Remove(audio);
        return store._audios; 
    }
    
    public static List<DVD> operator +(Store store, DVD dvd)
    {
        store._dvds.Add(dvd);
        return store._dvds;
    }
    
    public static List<DVD> operator -(Store store, DVD dvd)
    {
        store._dvds.Remove(dvd);
        return store._dvds;
    }


    public override string ToString()
    {
        string result = "******************\n";
        
        if (_audios.Count != 0)
        {
            result += ("Audio\n");
            foreach (Audio audio in _audios)
            {
                result += $"Название: {audio.Name}, артист: {audio.Artist} \n";
            }

            result += "******************\n";
        }
        else
        {
            result += "Аудио нет в наличии\n";
            result += "******************\n";
            
        }

        if (_dvds.Count != 0)
        {
            result += "Dvds\n";
            foreach (DVD dvd in _dvds)
            {
                result += $"Название: {dvd.Name}, режиссер: {dvd.Producer}\n";
            }
            result += "******************\n";
        }
        else
        {
            result += "Дивиди нет в наличии\n";
            result += "******************\n";
        }

        if (_audios.Count == 0 && _dvds.Count == 0)
        {
            result = "******************\n";
            result += "К сожалению, у данного магазина нет не аудио не дивиди:(\n";
            result += "******************\n";
        }
        
        return result;
    }

    public void WriteToConsoleAllDisksSize()
    {
        List<Disk> disks = new List<Disk>();
        
        disks.AddRange(_audios);
        disks.AddRange(_dvds);

        string result = "";
        foreach (Disk disk in disks)
        {
            result += $"{disk.Name} → {disk.DiskSize}\n";
        }

        Console.WriteLine(result);
    }
}