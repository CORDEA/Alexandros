using System;
using Newtonsoft.Json;

namespace Alexandros
{
    [JsonObject(MemberSerialization.OptOut)]
    public class SearchResult
    {

        public long ArtistId { get; set; }

        public long CollectionId { get; set; }

        public long TrackId { get; set; }

        public string ArtistName { get; set; }

        public string CollectionName { get; set; }

        public string TrackName { get; set; }

        public string CollectionCensoredName { get; set; }

        public string TrackCensoredName { get; set; }

        public string ArtistViewUrl { get; set; }

        public string CollectionViewUrl { get; set; }

        public string TrackViewUrl { get; set; }

        public string ArtworkUrl30 { get; set; }

        public string ArtworkUrl60 { get; set; }

        public string ArtworkUrl100 { get; set; }

        public float CollectionPrice { get; set; }

        public float TrackPrice { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int DiscCount { get; set; }

        public int DiscNumber { get; set; }

        public int TrackCount { get; set; }

        public int TrackNumber { get; set; }

        public long TrackTimeMillis { get; set; }

        public string Currency { get; set; }

    }
}