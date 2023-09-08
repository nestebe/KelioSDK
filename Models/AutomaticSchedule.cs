
// Type: KelioSDK.Models.AutomaticSchedule




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AutomaticSchedule")]
  public class AutomaticSchedule : ObjectBase
  {
    [XmlElement(DataType = "string", ElementName = "automaticScheduleAbbreviation", IsNullable = true)]
    public string AutomaticScheduleAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "automaticScheduleDescription", IsNullable = true)]
    public string AutomaticScheduleDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "absenceScheduleDescription", IsNullable = true)]
    public string AbsenceScheduleDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "absenceScheduleAbbreviation", IsNullable = true)]
    public string AbsenceScheduleAbbreviation { get; set; }
  }
}
