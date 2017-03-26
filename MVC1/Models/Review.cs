namespace MVC1.Models
{
	public class Review
	{
		public int ReviewID { get; set; }
		public Album Album{ get; set; }
		public string Contents { get; set; }
		public string EmailAddress { get; set; }
		public int AlbumID { get; set; }
		public int ArtistID { get; set; }
	}
}