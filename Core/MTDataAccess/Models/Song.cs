using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

/// <summary>
/// Summary description for Song
/// </summary>
public class Song
{
    public Song(int songID, DateTime dateCreation, int albumID, string albumName, string albumImg, int artistID, string title, decimal bPM, string timeSignature, bool multiTracks, bool customMix, bool chart, bool rehearsalMix, bool patches, bool songSpecificPatches, bool proPresenter)
    {
        SongID = songID;
        DateCreation = dateCreation;
        AlbumID = albumID;
        AlbumName = albumName;
        AlbumImg = albumImg;
        ArtistID = artistID;
        Title = title;
        BPM = bPM;
        TimeSignature = timeSignature;
        MultiTracks = multiTracks;
        CustomMix = customMix;
        Chart = chart;
        RehearsalMix = rehearsalMix;
        Patches = patches;
        SongSpecificPatches = songSpecificPatches;
        ProPresenter = proPresenter;
    }

    public int SongID { get; set; }
    public DateTime DateCreation { get; set; }
    public int AlbumID { get; set; }
    public string AlbumName { get; set; }
    public string AlbumImg { get; set; }
    public int ArtistID { get; set; }
    public string Title { get; set; }
    public decimal BPM { get; set; }
    public string TimeSignature { get; set; }
    public bool MultiTracks { get; set; }
    public bool CustomMix { get; set; }
    public bool Chart { get; set; }
    public bool RehearsalMix { get; set; }
    public bool Patches { get; set; }
    public bool SongSpecificPatches { get; set; }
    public bool ProPresenter { get; set; }

    public override bool Equals(object obj)
    {
        Song song = obj as Song;
        return !ReferenceEquals(song, null) &&
               SongID == song.SongID;
    }

    public override int GetHashCode()
    {
        return 1552943393 + SongID.GetHashCode();
    }
}