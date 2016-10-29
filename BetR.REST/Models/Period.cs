using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace BetR.REST.Models
{
    [XmlType("period")]
    public class Period
    {
        public string period_number { get; set; }
        public string period_description { get; set; }
        public string periodcutoff_datetimeGMT { get; set; }
        public string period_status { get; set; }
        public string period_update { get; set; }
        public string spread_maximum { get; set; }
        public string moneyline_maximum { get; set; }
        public string total_maximum { get; set; }
        public MoneyLine moneyline { get; set; }
        public Spread spread { get; set; }
        public Total total { get; set; }
    }
}