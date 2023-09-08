
// Type: KelioSDK.Models.MaxTimeWindow




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "MaxTimeWindow")]
  public class MaxTimeWindow : DailyScheduleWindow
  {
    [XmlElement(DataType = "double", ElementName = "maxTime", IsNullable = true)]
    public double? MaxTime { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "maxTimeIsContinuous", IsNullable = true)]
    public bool? MaxTimeIsContinuous { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "maxTimeValueIsRelative", IsNullable = true)]
    public bool? MaxTimeValueIsRelative { get; set; }
  }
}
