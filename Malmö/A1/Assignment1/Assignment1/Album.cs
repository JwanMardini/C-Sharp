using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Album
    {
        private string albumName; // Stores the name of the album
        private string artistName; // Stores the name of the artist or band
        private int numOfTracks; // Stores the number of tracks in the album
        private DateTime releaseDate; // Stores the release date of the album

        // Method to read and save the album name
        public void ReadAlbumName()
        {
            Console.WriteLine("What is the name of your favorite music album?");
            this.albumName = Console.ReadLine();
        }

        // Method to read and save the release date of the album
        public void ReadReleaseDate()
        {
            Console.WriteLine($"When was {this.albumName} released (mm/dd/yyyy)?");
            string input = Console.ReadLine();
            this.releaseDate = DateTime.Parse(input);
        }

        // Method to read and save the name of the artist or band
        public void ReadArtistName()
        {
            Console.WriteLine($"What is the name of the Artist or Band for {this.albumName}");
            this.artistName = Console.ReadLine();
        }

        // Method to read and save the number of tracks in the album
        public void ReadTracks()
        {
            Console.WriteLine($"How many tracks does {this.albumName} have?");
            string input = Console.ReadLine();
            this.numOfTracks = int.Parse(input);
        }

        // Method to display album information
        public void DisplayAlbumInfo()
        {
            Console.WriteLine($"Album Name: {this.albumName}");
            Console.WriteLine($"Release Date: {this.releaseDate.ToString("yyyy-MM-dd")}");
            Console.WriteLine($"Artist/Band: {this.artistName}");
            Console.WriteLine($"Number of Tracks: {this.numOfTracks}");
            Console.WriteLine("Enjoy listening!");
        }

        // Method to start interaction with the Album class
        public void Start()
        {
            Console.WriteLine("Starting the Album Program!");
            Console.WriteLine();
            ReadAlbumName(); // Read and save album name
            ReadReleaseDate(); // Read and save release date
            ReadArtistName(); // Read and save artist/band name
            ReadTracks(); // Read and save number of tracks
            Console.WriteLine();
            DisplayAlbumInfo(); // Display album information
            Console.WriteLine();
        }
    }
}
