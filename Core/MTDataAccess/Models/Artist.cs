using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Artist
/// </summary>
public class Artist
{

    public Artist()
    {
        ArtistID = -1;
        DateCreation = DateTime.Now;
        Title = "Artist Not Found";
        Biography = "Artist Not Found";
        ImageURL = string.Empty;
        HeroURL = string.Empty;
    }

    public Artist(int artistID, DateTime dateCreation, string title, string biography, string imageURL, string heroURL)
    {
        ArtistID = artistID;
        DateCreation = dateCreation;
        Title = title;
        Biography = biography;
        ImageURL = imageURL;
        HeroURL = heroURL;

        Albums = new HashSet<Album>();
        Songs = new HashSet<Song>();
    }


    public int ArtistID { get; set; }
    public DateTime DateCreation { get; set; }
    public string Title { get; set; }
    public string Biography { get; set; }
    public string ImageURL { get; set; }
    public string HeroURL { get; set; }

    public HashSet<Album> Albums { get; set; }
    public HashSet<Song> Songs { get; set; }
}