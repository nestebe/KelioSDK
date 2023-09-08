
// Type: KelioSDK.Models.FromDateToDateSpecialHourTotal




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "FromDateToDateSpecialHourTotal")]
  public class FromDateToDateSpecialHourTotal : AbstractFromDateToDateTotal
  {
    [XmlElement(DataType = "double", ElementName = "hours", IsNullable = true)]
    public double? Hours { get; set; }
  }
}
