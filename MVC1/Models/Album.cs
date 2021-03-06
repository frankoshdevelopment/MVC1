﻿using System.Collections.Generic;

namespace MVC1.Models
{
	public class Album
	{
		public int AlbumID { get; set; }
		public string Title { get; set; }
		public Artist Artist { get; set; }
		public int ArtistID { get; set; }
		public virtual List<Review> Review { get; set; }
	}
}