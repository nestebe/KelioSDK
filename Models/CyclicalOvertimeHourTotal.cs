
// Type: KelioSDK.Models.CyclicalOvertimeHourTotal




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "CyclicalOvertimeHourTotal")]
  public class CyclicalOvertimeHourTotal : AbstractCyclicalTotal
  {
    [XmlElement(DataType = "double", ElementName = "hours", IsNullable = true)]
    public double? Hours { get; set; }
  }
}
