using DataAccess;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace MutiTracksAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SongController : ControllerBase
    {

        private readonly ILogger<SongController> _logger;

        public SongController(ILogger<SongController> logger)
        {
            _logger = logger;
        }

        [HttpGet("List/{pageSize}/{page}")]
        public IEnumerable<Song> List(int pageSize, int page)
        {
            int offset = pageSize * (page - 1);
            List<Song> songs = new List<Song>();

            var sql = new SQL();
            DataTable data = sql.ExecuteStoredProcedureDT("ListSongs");

            if (data.Rows.Count > 0)
            {
                var top = offset+pageSize > data.Rows.Count ? data.Rows.Count : offset+pageSize;

                for (var i = offset; i < top; i++)
                {
                    songs.Add(new Song(
                                    data.Rows[i].Field<int>("songID"),
                                    data.Rows[i].Field<DateTime>("dateCreation"),
                                    data.Rows[i].Field<int>("albumID"),
                                    string.Empty,
                                    string.Empty,
                                    data.Rows[i].Field<int>("artistID"),
                                    data.Rows[i].Field<string>("title"),
                                    data.Rows[i].Field<decimal>("bpm"),
                                    data.Rows[i].Field<string>("timeSignature"),
                                    data.Rows[i].Field<bool>("multiTracks"),
                                    data.Rows[i].Field<bool>("customMix"),
                                    data.Rows[i].Field<bool>("chart"),
                                    data.Rows[i].Field<bool>("rehearsalMix"),
                                    data.Rows[i].Field<bool>("patches"),
                                    data.Rows[i].Field<bool>("songSpecificPatches"),
                                    data.Rows[i].Field<bool>("proPresenter")));

                }
            }
            return songs;
        }
    }
}