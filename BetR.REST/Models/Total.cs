using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace BetR.REST.Models
{
    [XmlType("total")]
    public class Total
    {
        public string total_points { get; set; }
        public string over_adjust { get; set; }
        public string under_adjust { get; set; }
    }
}