using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace BetR.REST.Models
{
    [XmlType("event")]
    public class Event
    {
        public string event_datetimeGMT { get; set; }
        public string gamenumber { get; set; }
        public string sporttype { get; set; }
        public string league { get; set; }
        public string IsLive { get; set; }
        public List<Participant> participants { get; set; }
        public List<Period> periods { get; set;}
    }

}