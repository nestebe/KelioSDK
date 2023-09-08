
// Type: KelioSDK.Models.PeriodicOvertimeHourTotal




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "PeriodicOvertimeHourTotal")]
  public class PeriodicOvertimeHourTotal : AbstractPeriodicTotal
  {
    [XmlElement(DataType = "double", ElementName = "hours", IsNullable = true)]
    public double? Hours { get; set; }
  }
}
