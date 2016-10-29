using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace BetR.REST.Models
{
    [XmlType("spread")]
    public class Spread
    {
        public string spread_visiting { get; set; }
        public string spread_adjust_visiting { get; set; }
        public string spread_home { get; set; }
        public string spread_adjust_home { get; set; }
    }
}