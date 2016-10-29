using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace BetR.REST.Models
{
    [XmlType("pinnacle_line_feed")]
    public class PinnacleLineFeed
    {
        public string PinnacleFeedTime { get; set; }
        public string lastContest { get; set; }
        public string lastGame { get; set; }  
        public List<Event> events { get; set; }
    }
}