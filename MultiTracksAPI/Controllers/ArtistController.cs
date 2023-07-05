using DataAccess;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace MutiTracksAPI.Controllers
{
    [ApiController]
    [Route("api.multitracks.com/[controller]")]
    public class ArtistController : ControllerBase
    {

        private readonly ILogger<ArtistController> _logger;

        public ArtistController(ILogger<ArtistController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Search/{artistName}")]
        public IEnumerable<Artist> Search(string artistName)
        {
            List<Artist> artists = new List<Artist>();
            var sql = new SQL();

            sql.Parameters.Add("@artistName", artistName);
            DataTable data = sql.ExecuteStoredProcedureDT("GetArtistsByName");

            if (data.Rows.Count > 0)
            {

                foreach (DataRow row in data.Rows)
                {
                    artists.Add(new Artist(
                                    row.Field<int>("artistID"),
                                    row.Field<DateTime>("dateCreation"),
                                    row.Field<string>("title"),
                                    row.Field<string>("biography"),
                                    row.Field<string>("imageURL"),
                                    row.Field<string>("heroURL")));

                }
            }
            return artists;
        }

        [HttpPost("Add")]
        public Artist AddArtist([FromBody] Artist artist)
        {
            var sql = new SQL();

            sql.Parameters.Add("@dateCreation", artist.DateCreation);
            sql.Parameters.Add("@title", artist.Title);
            sql.Parameters.Add("@biography", artist.Biography);
            sql.Parameters.Add("@imageURL", artist.ImageURL);
            sql.Parameters.Add("@heroURL", artist.HeroURL);
            sql.ExecuteStoredProcedure("AddArtist");

            return artist;
        }
    }
}