
// Type: KelioSDK.Models.AccessAnnualCrossingSchedule




using KelioSDK.Common;
using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AccessAnnualCrossingSchedule")]
  public class AccessAnnualCrossingSchedule : ObjectBase
  {
    [XmlElement(DataType = "int", ElementName = "accessAnnualCrossingSchedulesKey", IsNullable = true)]
    public int? AccessAnnualCrossingSchedulesKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "accessAnnualCrossingSchedulesDescription", IsNullable = true)]
    public string AccessAnnualCrossingSchedulesDescription { get; set; }

    [XmlElement(DataType = "date", ElementName = "startDate", IsNullable = true)]
    public DateTime? StartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "endDate", IsNullable = true)]
    public DateTime? EndDate { get; set; }

    [XmlElement(DataType = "short", ElementName = "assignmentMode", IsNullable = true)]
    public short? AssignmentMode { get; set; }

    [XmlElement(DataType = "string", ElementName = "accessWeeklyCrossingScheduleDescription", IsNullable = true)]
    public string AccessWeeklyCrossingScheduleDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "accessDailyCrossingScheduleDescription", IsNullable = true)]
    public string AccessDailyCrossingScheduleDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "during", IsNullable = true)]
    public int? During { get; set; }

    [XmlElement(DataType = "int", ElementName = "every", IsNullable = true)]
    public int? Every { get; set; }
  }
}
