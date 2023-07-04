using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.UI.WebControls;

public partial class artistAlbums : MultitracksPage
{
    private Artist artist;

    protected void Page_Load(object sender, EventArgs e)
    {
        var sql = new SQL();

        sql.Parameters.Add("@artistID", 5);
        DataTable data = sql.ExecuteStoredProcedureDT("GetArtistDetails");

        artist = BuildArtistProfile(data);

        LoadArtist();
        LoadAlbums();
    }

    private Artist BuildArtistProfile(DataTable data)
    {

        if(data.Rows.Count > 0)
        {
            Artist artist = new Artist(
                                data.Rows[0].Field<int>("artistID"),
                                data.Rows[0].Field<DateTime>("dateCreation"),
                                data.Rows[0].Field<string>("title"),
                                data.Rows[0].Field<string>("biography"),
                                data.Rows[0].Field<string>("imageURL"),
                                data.Rows[0].Field<string>("heroURL"));
            
            foreach (DataRow row in data.Rows)
            {
                Album album = new Album(
                                    row.Field<int>("albumID"),
                                    row.Field<DateTime>("dateCreation1"),
                                    row.Field<int>("artistId1"),
                                    row.Field<string>("title"),
                                    row.Field<string>("title1"),
                                    row.Field<string>("imageURL1"),
                                    row.Field<int>("year"));

                Song song = new Song(
                                    row.Field<int>("songID"),
                                    row.Field<DateTime>("dateCreation2"),
                                    row.Field<int>("albumID1"),
                                    row.Field<string>("title1"),
                                    row.Field<string>("imageURL1"),
                                    row.Field<int>("artistID1"),
                                    row.Field<string>("title2"),
                                    row.Field<decimal>("bpm"),
                                    row.Field<string>("timeSignature"),
                                    row.Field<bool>("multiTracks"),
                                    row.Field<bool>("customMix"),
                                    row.Field<bool>("chart"),
                                    row.Field<bool>("rehearsalMix"),
                                    row.Field<bool>("patches"),
                                    row.Field<bool>("songSpecificPatches"),
                                    row.Field<bool>("proPresenter"));


                artist.Albums.Add(album);
                artist.Songs.Add(song);
            }

            
            return artist;
        }


        return new Artist();
    }

    private void LoadArtist()
    {
        artistTitle.Text = artist.Title;
        artistImage.ImageUrl = artist.ImageURL;
        heroImage.ImageUrl = artist.HeroURL;
    }

    private void LoadAlbums()
    {
        albums.DataSource = artist.Albums;
        albums.DataBind();
    }

    protected void AlbumRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item ||
            e.Item.ItemType == ListItemType.AlternatingItem)
        {
            var album = e.Item.DataItem as Album;

            var control = e.Item.FindControl("album") as PageToSync_UserControls_AlbumUserControl;
            control.SetData(album);
        }
    }

}