
// Type: KelioSDK.Models.RoundingOnClockingWindow




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "RoundingOnClockingWindow")]
  public class RoundingOnClockingWindow : DailyScheduleWindow
  {
    [XmlElement(DataType = "boolean", ElementName = "isClockingInRounding", IsNullable = true)]
    public bool? IsClockingInRounding { get; set; }

    [XmlElement(DataType = "double", ElementName = "tolerance", IsNullable = true)]
    public double? Tolerance { get; set; }

    [XmlElement(DataType = "double", ElementName = "rounding", IsNullable = true)]
    public double? Rounding { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "roundingWithPreviousClockingOutRespect", IsNullable = true)]
    public bool? RoundingWithPreviousClockingOutRespect { get; set; }
  }
}
