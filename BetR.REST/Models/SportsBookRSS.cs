using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace BetR.REST.Models
{
    [XmlRoot(ElementName = "guid")]
    public class Guid
    {
        [XmlAttribute(AttributeName = "isPermaLink")]
        public string IsPermaLink { get; set; }
    }

    [XmlRoot(ElementName = "item")]
    public class Item
    {
        [XmlElement(ElementName = "title")]
        public string Title { get; set; }
        [XmlElement(ElementName = "link")]
        public string Link { get; set; }
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
        [XmlElement(ElementName = "pubDate")]
        public string PubDate { get; set; }
        [XmlElement(ElementName = "creator", Namespace = "http://purl.org/dc/elements/1.1/")]
        public string Creator { get; set; }
        [XmlElement(ElementName = "guid")]
        public Guid Guid { get; set; }
    }

    [XmlRoot(ElementName = "channel")]
    public class Channel
    {
        [XmlElement(ElementName = "title")]
        public string Title { get; set; }
        [XmlElement(ElementName = "link")]
        public string Link { get; set; }
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
        [XmlElement(ElementName = "language")]
        public string Language { get; set; }
        [XmlElement(ElementName = "item")]
        public List<Item> Item { get; set; }
    }

    [XmlRoot(ElementName = "rss")]
    public class Rss
    {
        [XmlElement(ElementName = "channel")]
        public Channel Channel { get; set; }
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
        [XmlAttribute(AttributeName = "base", Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string Base { get; set; }
        [XmlAttribute(AttributeName = "dc", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Dc { get; set; }
    }

}
