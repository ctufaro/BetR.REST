using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BetR.REST.Models;
using System.IO;
using System.Text.RegularExpressions;

namespace BetR.REST.Controllers
{
    public class GamesController : ApiController
    {
        // GET: api/Home/5
        public SportsBook Get()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            string feed = "http://www.sportsbook.ag/rss/nfl-football";
            string downloadString = new WebClient().DownloadString(feed);
            return ProcessFeed((Rss)XMLParse.ObjectToXML(downloadString, typeof(Rss)));
        }

        private string GetHTML(string shtml)
        {
            return shtml.Substring(shtml.IndexOf(">") + 1, shtml.IndexOf("</a>") - shtml.IndexOf(">") - 1);
        }

        private SportsBook ProcessFeed(Rss rssFeed)
        {
            SportsBook sBook = new SportsBook();
            foreach (var data in rssFeed.Channel.Item)
            {
                string[] teams = data.Title.Split(new char[] { '@' });
                string HomeTeam = teams[1].Trim();
                string HomeMoneyLine = "";
                string HomeSpread = "";
                string AwayTeam = teams[0].Trim();
                string AwayMoneyLine = "";
                string AwaySpread = "";
                string Over = "";
                string Under = "";
                string GameTime = data.PubDate;

                string[] rawRSS = data.Description.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                if (rawRSS.Length == 7)
                {
                    AwayMoneyLine = GetHTML(rawRSS[2]);
                    HomeMoneyLine = GetHTML(rawRSS[4]);
                    AwaySpread = GetHTML(rawRSS[1]).Split(new char[]{' '})[0].Trim();
                    HomeSpread = GetHTML(rawRSS[3]).Split(new char[] { ' ' })[0].Trim();
                    Over = GetHTML(rawRSS[5]).Split(new char[] { ' ' })[1].Trim();
                    Under = GetHTML(rawRSS[6]).Split(new char[] { ' ' })[1].Trim();
                }

                sBook.SportsBookMain.Add(new SportsBookItem
                {
                    MoneyLineVisiting = AwayMoneyLine,
                    SpreadVisiting = AwaySpread,
                    TeamVisiting = AwayTeam,
                    MoneyLineHome = HomeMoneyLine,
                    SpreadHome = HomeSpread,
                    TeamHome = HomeTeam,
                    EventDate = GameTime,
                    OverAdjust = Over,
                    UnderAdjust = Under,
                    TotalPoints = Under
                });

            }

            return sBook;//(Rss)XMLParse.ObjectToXML(downloadString, typeof(Rss));
        }
    }
}
