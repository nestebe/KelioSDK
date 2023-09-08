
// Type: KelioSDK.Models.ShiftScheduleDistribution




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "ShiftScheduleDistribution")]
  public class ShiftScheduleDistribution : ObjectBase
  {
    [XmlElement(DataType = "string", ElementName = "shiftScheduleDescription", IsNullable = true)]
    public string ShiftScheduleDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "shiftScheduleKey", IsNullable = true)]
    public int? ShiftScheduleKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "shiftScheduleAbbreviation", IsNullable = true)]
    public string ShiftScheduleAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "shiftScheduleShiftDescription", IsNullable = true)]
    public string ShiftScheduleShiftDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "shiftScheduleWeekDescription", IsNullable = true)]
    public string ShiftScheduleWeekDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "shiftScheduleShiftNumber", IsNullable = true)]
    public int? ShiftScheduleShiftNumber { get; set; }

    [XmlElement(DataType = "int", ElementName = "shiftScheduleWeekNumber", IsNullable = true)]
    public int? ShiftScheduleWeekNumber { get; set; }
  }
}
