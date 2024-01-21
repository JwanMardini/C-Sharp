using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Album
    {
        private string albumName;
        private string artistName;
        private int numOfTracks;

        public void ReadAlbumName()
        {
            Console.WriteLine("What is the name of your favorite music album?");
            this.albumName = Console.ReadLine();
        }
        public void ReadArtistName()
        {
            Console.WriteLine($"What is the name of the Artist or Band for {this.albumName}");
            this.artistName = Console.ReadLine();

        }

        public void ReadTracks()
        {
            Console.WriteLine($"How many tracks does {this.albumName} have?");
            string input = Console.ReadLine();
            this.numOfTracks = int.Parse(input);

        }

        public void DisplayAlbumInfo()
        {
            Console.WriteLine($"Album Name: {this.albumName}");
            Console.WriteLine($"Artist/Band: {this.artistName}");
            Console.WriteLine($"Nummber of Tracks: {this.numOfTracks}");
            Console.WriteLine("Enjoy listening!");
        }

        public void Start()
        {
            Console.WriteLine("Starting the Album Program!");
            Console.WriteLine();
            ReadAlbumName();
            ReadArtistName();
            ReadTracks();
            Console.WriteLine();
            DisplayAlbumInfo();
            Console.WriteLine();
        }


    }
}
