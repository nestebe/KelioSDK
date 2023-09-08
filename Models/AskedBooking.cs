
// Type: KelioSDK.Models.AskedBooking




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AskedBooking")]
  public class AskedBooking : AbstractAskedByDates
  {
    [XmlElement(DataType = "string", ElementName = "siteFilter", IsNullable = true)]
    public string SiteFilter { get; set; }

    [XmlElement(DataType = "string", ElementName = "roomFilter", IsNullable = true)]
    public string RoomFilter { get; set; }
  }
}
