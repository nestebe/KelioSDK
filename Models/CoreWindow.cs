
// Type: KelioSDK.Models.CoreWindow




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "CoreWindow")]
  public class CoreWindow : DailyScheduleWindow
  {
    [XmlElement(DataType = "boolean", ElementName = "anomalyIfNoWork", IsNullable = true)]
    public bool? AnomalyIfNoWork { get; set; }
  }
}
