using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace BetR.REST.Models
{
    [XmlType("moneyline")]
    public class MoneyLine
    {
        public string moneyline_visiting { get; set; }
        public string moneyline_home { get; set; }
    }
}