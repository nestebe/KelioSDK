
// Type: KelioSDK.Models.FromDateToDateOvertimeHourTotal




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "FromDateToDateOvertimeHourTotal")]
  public class FromDateToDateOvertimeHourTotal : AbstractFromDateToDateTotal
  {
    [XmlElement(DataType = "double", ElementName = "hours", IsNullable = true)]
    public double? Hours { get; set; }
  }
}
