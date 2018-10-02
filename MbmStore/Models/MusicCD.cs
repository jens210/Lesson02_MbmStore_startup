using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class MusicCD : Product
    {
        public string Artist { get; set; }
        public string Label { get; set; }
        private short Released { get; set; }
        public List<Track> Tracks { get; } = new List<Track>();

        public MusicCD()
        {

        }

        public MusicCD(string artist, string title, decimal price, short released, string imageURL, int productID) : base(title, price, imageURL, productID)
        {
            Artist = artist;
            Title = title;
            Price = price;
            Released = released;
            ImageURL = imageURL;
            ProductID = productID;
        }

        public void AddTrack(Track track)
        {
            Tracks.Add(track);
        }

        public TimeSpan GetPlayingTime()
        {
            TimeSpan sum;
            foreach(Track track in this.Tracks)
            {
                sum += track.Length;
            }
            return sum;
        }
    }
}
