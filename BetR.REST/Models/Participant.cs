using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace BetR.REST.Models
{
    [XmlType("participant")]
    public class Participant
    {
        public string participant_name { get; set; }
        public string contestantnum { get; set; }
        public string rotnum { get; set; }
        public string visiting_home_draw { get; set; }
    }
}