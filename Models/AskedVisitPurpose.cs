
// Type: KelioSDK.Models.AskedVisitPurpose




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AskedVisitPurpose")]
  public class AskedVisitPurpose : AbstractAskedByDates
  {
    [XmlElement(DataType = "string", ElementName = "siteFilter", IsNullable = true)]
    public string SiteFilter { get; set; }

    [XmlElement(DataType = "string", ElementName = "visitFieldDescription", IsNullable = true)]
    public string VisitFieldDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "visitFieldKey", IsNullable = true)]
    public int? VisitFieldKey { get; set; }
  }
}
