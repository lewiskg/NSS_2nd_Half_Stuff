using System;
using System.Collections.Generic;


namespace Kill_Nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> goodSongs = new List<Song>();

            List<Song> allSongs = new List<Song>()
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

            foreach (Song song in allSongs)
            {
                if (song.Name != "Nickleback")
                {
                    goodSongs.Add(song);
                }
            }

            foreach (Song song in goodSongs)
            {
                song.printSong();
            }

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
}
