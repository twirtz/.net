using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PageToSync_UserControls_SongUserControl : System.Web.UI.UserControl
{
    private Song _dataSource;
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    public void SetData(Song song)
    {
        songImg.ImageUrl = song.AlbumImg;
        songTitle.Text = song.Title;
        songAlbum.Text = song.AlbumName;
        songBPM.Text = song.BPM.ToString();
        songTS.Text = song.TimeSignature;

        if (song.MultiTracks)
        {
            mt.ForeColor = System.Drawing.ColorTranslator.FromHtml("#43b1e6");
        }
        if (song.CustomMix)
        {
            cm.ForeColor = System.Drawing.ColorTranslator.FromHtml("#43b1e6");
        }
        if (song.RehearsalMix)
        {
            mt.ForeColor = System.Drawing.ColorTranslator.FromHtml("#43b1e6");
        }
        if (song.Patches)
        {
            sds.ForeColor = System.Drawing.ColorTranslator.FromHtml("#43b1e6");
        }
        if (song.Chart)
        {
            ch.ForeColor = System.Drawing.ColorTranslator.FromHtml("#43b1e6");
        }
        if (song.ProPresenter)
        {
            pp.ForeColor = System.Drawing.ColorTranslator.FromHtml("#43b1e6");
        }
    }
}