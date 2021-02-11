using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using Models;

namespace SqliteFromScratch.Controllers {
    // MVC is handling the routing for you.
    [Route("api/[Controller]")]
    public class DatabaseController : Controller {

        // api/database
        [HttpGet]
        public List<Track> GetData() {
          // tracks will be populated with the result of the query.
          List<Track> tracks = new List<Track>();

          // GetFullPath will return a string to complete the absolute path.
          string dataSource = "Data Source=" + Path.GetFullPath("chinook.db");

          return tracks;
        }
    }
}