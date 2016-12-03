using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BetR.REST.Models
{
    public class SportsBookItem
    {
        public string EventDate { get; set; }
        public string TeamHome { get; set; }
        public string MoneyLineHome { get; set; }
        public string SpreadHome { get; set; }
        public string TeamVisiting { get; set; }
        public string MoneyLineVisiting { get; set; }
        public string SpreadVisiting { get; set; }
        public string OverAdjust { get; set; }
        public string UnderAdjust { get; set; }
        public string TotalPoints { get; set; }

        public SportsBookItem() { }
    } 

    public class SportsBook
    {
        public List<SportsBookItem> SportsBookMain { get; set; }
        public SportsBook() 
        {
            this.SportsBookMain = new List<SportsBookItem>();
        }
    }
}