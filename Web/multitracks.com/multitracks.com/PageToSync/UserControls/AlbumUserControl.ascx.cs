using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PageToSync_UserControls_AlbumUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void SetData(Album album)
    {
        albumImg.ImageUrl = album.ImageURL;
        albumTitle.Text = album.Title;
        artistName.Text = album.ArtistName;
    }
}