using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BetR.REST.Models;

namespace BetR.REST.Controllers
{
    public class GamesController : ApiController
    {
        // GET: api/Home/5
        public PinnacleLineFeed Get()
        {
            string downloadString = new WebClient().DownloadString("http://xml.pinnaclesports.com/pinnaclefeed.aspx?sporttype=Football&sportsubtype=nfl");
            return (PinnacleLineFeed)XMLParse.ObjectToXML(downloadString, typeof(PinnacleLineFeed));
        }
    }
}
