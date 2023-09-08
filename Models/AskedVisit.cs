
// Type: KelioSDK.Models.AskedVisit




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AskedVisit")]
  public class AskedVisit : AbstractAskedByDates
  {
    [XmlElement(DataType = "string", ElementName = "siteFilter", IsNullable = true)]
    public string SiteFilter { get; set; }
  }
}
