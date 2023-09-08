
// Type: KelioSDK.Models.ToleranceWindow




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "ToleranceWindow")]
  public class ToleranceWindow : DailyScheduleWindow
  {
    [XmlElement(DataType = "boolean", ElementName = "inTolerance", IsNullable = true)]
    public bool? InTolerance { get; set; }
  }
}
