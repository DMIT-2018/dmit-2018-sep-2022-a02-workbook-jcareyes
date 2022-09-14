<Query Kind="Expression" />

// HOMEWORK!!!
// List all albums showing the Title, Artist Name, Year and Decade of Release.
// (Oldies, 70s, 80s, 90s or Modern)
// Order by decades.

// (Not for marks)

Albums
	.Select(x => new
	{
		Title = x.Title,
		Artist = x.Artist.Name,
		Year = x.ReleaseYear,
		Decade = x.ReleaseYear < 1970 ? "Oldies" :
					x.ReleaseYear < 1980 ? "70s" :
					x.ReleaseYear < 1990 ? "80s" : 
					x.ReleaseYear < 2000 ? "90s" : 
					"Modern"
	}).OrderBy(x => x.Year).Dump()
	