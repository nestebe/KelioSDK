
// Type: KelioSDK.Models.PerpetualOvertimeHourTotal




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "PerpetualOvertimeHourTotal")]
  public class PerpetualOvertimeHourTotal : AbstractPerpetualTotal
  {
    [XmlElement(DataType = "double", ElementName = "hours", IsNullable = true)]
    public double? Hours { get; set; }
  }
}
