using System;

namespace WaspHomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store blackStart = new Store("BlackStar", "Улица Пушкина дом калотушкина");
            
            Audio audio = new Audio("Агония альбом", "ХипХоп", "Слава Марлоу", "Андрюха", 41);
            Audio audio1 = new Audio("Селяви альбом", "ХипХоп", "Моргенштерн", "Андрюха", 666);
            
            DVD dvd = new DVD("Ходячий замок", "Аниме", "Хаяо Миядзаки", "Крутая кампания", 240);
            DVD dvd1 = new DVD("Джо-Джо", "Джо-Джо", "Джо-Джо", "ОРЭОРЭОРЭОРЭ", 24);
            DVD dvd2 = new DVD("Наруто", "Аниме", "Крутой", "терияки", 22);
                
            blackStart.Audios = blackStart + audio;
            blackStart.Audios = blackStart + audio1;
            
            // blackStart.Audios = blackStart - audio;
            // blackStart.Audios = blackStart - audio1;

            blackStart.Dvds = blackStart + dvd;
            blackStart.Dvds = blackStart + dvd1;
            blackStart.Dvds = blackStart + dvd2;
            blackStart.Dvds = blackStart - dvd1;
            
            // blackStart.Dvds = blackStart - dvd;
            // blackStart.Dvds = blackStart - dvd2;


            
            Console.WriteLine(blackStart);
            
            dvd1.Burn("Прозжиг диска");
            
            
            blackStart.WriteToConsoleAllDisksSize();
        }
    }
}
