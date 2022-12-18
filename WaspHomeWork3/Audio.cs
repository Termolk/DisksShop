namespace WaspHomeWork3;

public class Audio : Disk
{
     public string Artist { get; set; }
     public string RecordingStudio { get; set; }
     public int SongsNumber { get; set; }
    
    public Audio(string name, string genre, string artist, string recordingStudio, int songsNumber)
        : base(name, genre)
    {
        Artist = artist;
        RecordingStudio = recordingStudio;
        SongsNumber = songsNumber;
    }

    public override int DiskSize { get => SongsNumber * 8; }

    public override void Burn(params string[] values)
    {
        foreach (string ch in values)
        {
            
        }
        BurnCount++;
    }

    

    public override string ToString()
    {
        return $"{Name}, {Genre}, {Artist}, {RecordingStudio}, {SongsNumber}, {BurnCount}";
    }
}