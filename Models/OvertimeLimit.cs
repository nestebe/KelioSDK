
// Type: KelioSDK.Models.OvertimeLimit




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "OvertimeLimit")]
  public class OvertimeLimit : ObjectBase
  {
    [XmlElement(DataType = "string", ElementName = "overtimeTypeAbbreviation", IsNullable = true)]
    public string OvertimeTypeAbbreviation { get; set; }

    [XmlElement(DataType = "int", ElementName = "overtimeLimitKey", IsNullable = true)]
    public int? OvertimeLimitKey { get; set; }

    [XmlElement(DataType = "double", ElementName = "overtimeLimitValue", IsNullable = true)]
    public double? OvertimeLimitValue { get; set; }

    [XmlElement(DataType = "string", ElementName = "scheduleAbbreviation", IsNullable = true)]
    public string ScheduleAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "scheduleDescription", IsNullable = true)]
    public string ScheduleDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "weekRank", IsNullable = true)]
    public int? WeekRank { get; set; }
  }
}
