using System;
using System.Collections.Generic;


namespace Kill_Nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            Jukebox player = new Jukebox();

            player.printAllSongList();
            player.addToGoodSongs();
            player.printGoodSongList();
        }
    }

    class Song
    {
        public string Name { get; set;}
        public string Artist { get; set;}

        public void printSong()
        {
            Console.WriteLine("{0}: {1}", Name, Artist);
        }
    }

    class Jukebox
    {
        public List<Song> goodSongs = new List<Song>();

        public List<Song> allSongs = new List<Song>()
            {
                new Song(){Name = "Nickleback", Artist = "Photograph"},
                new Song(){Name = "Nickleback", Artist = "How You Remind Me"},
                new Song(){Name = "Nickleback", Artist = "Rockstar"},
                new Song(){Name = "Justin Timberlake", Artist = "Filthy"},
                new Song(){Name = "Demi Lovato", Artist = "Sorry Not Sorry"},
                new Song(){Name = "Eminem", Artist = "River"},
                new Song(){Name = "Bruno Mars", Artist = "That's What I Like"},
                new Song(){Name = "Maren Morris", Artist = "I Could Use A Love Song"},
                new Song(){Name = "Blake Shelton", Artist = "I'll Name The Dogs"},
                new Song(){Name = "Taylor Swift", Artist = "...Ready For It?"}
            };

        public void addToGoodSongs()
        {
            foreach (Song song in allSongs)
            {
                if (song.Name != "Nickleback")
                {
                    goodSongs.Add(song);
                }
            }
        }

        public void printGoodSongList()
        {
            Console.WriteLine("\nGood songs in jukebox:");
            foreach (Song song in goodSongs)
            {
                song.printSong();
            }
        }

        public void printAllSongList()
        {
            Console.WriteLine("\nAll songs in jukebox:");
            foreach (Song song in allSongs)
            {
                song.printSong();
            }
        }

    }
}
