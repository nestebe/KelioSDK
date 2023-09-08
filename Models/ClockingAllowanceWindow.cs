
// Type: KelioSDK.Models.ClockingAllowanceWindow




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "ClockingAllowanceWindow")]
  public class ClockingAllowanceWindow : DailyScheduleWindow
  {
    [XmlElement(DataType = "boolean", ElementName = "isAllowanceAppliesToHourToHourAbsence", IsNullable = true)]
    public bool? IsAllowanceAppliesToHourToHourAbsence { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "isClockingInAllowance", IsNullable = true)]
    public bool? IsClockingInAllowance { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "neutralizationIfOTAUsed", IsNullable = true)]
    public bool? NeutralizationIfOTAUsed { get; set; }
  }
}
