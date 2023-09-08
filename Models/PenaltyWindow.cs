
// Type: KelioSDK.Models.PenaltyWindow




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "PenaltyWindow")]
  public class PenaltyWindow : DailyScheduleWindow
  {
    [XmlElement(DataType = "double", ElementName = "penaltyDuration", IsNullable = true)]
    public double? PenaltyDuration { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "clockingsOutAppliement", IsNullable = true)]
    public bool? ClockingsOutAppliement { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "clockingsInAppliement", IsNullable = true)]
    public bool? ClockingsInAppliement { get; set; }
  }
}
