using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Album
/// </summary>
public class Album
{
    public Album(int albumID, DateTime dateCreation, int artistID, string artistName, string title, string imageURL, int year)
    {
        AlbumID = albumID;
        DateCreation = dateCreation;
        ArtistID = artistID;
        ArtistName = artistName;
        Title = title;
        ImageURL = imageURL;
        Year = year;
    }

    public int AlbumID { get; set; }
    public DateTime DateCreation { get; set; }
    public int ArtistID { get; set; }
    public string ArtistName { get; set; }

    public string Title { get; set; }
    public string ImageURL { get; set; }
    public int Year { get; set; }

    public override bool Equals(Object obj)
    {
        var album = obj as Album;
        return !ReferenceEquals(album, null) &&
            album.AlbumID == AlbumID;
    }

    public override int GetHashCode()
    {
        return 1392290281 + AlbumID.GetHashCode();
    }
}