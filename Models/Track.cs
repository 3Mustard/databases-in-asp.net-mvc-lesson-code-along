namespace Models
{
    public class Track
    {
        public int TrackId { get; set; }
        public string Name { get; set; }
        public int MediaTypeId { get; set; }
        public string Composer { get; set; }
        public int Milliseconds { get; set; }
        public int UnitPrice { get; set; }
        //NULLABLE PROPERTIES
        #nullable enable
        public int? AlbumId { get; set; }
        public int? Bytes { get; set; }
        public int? GenreId { get; set; }
        #nullable disable
    }
}