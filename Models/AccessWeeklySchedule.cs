
// Type: KelioSDK.Models.AccessWeeklySchedule




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AccessWeeklySchedule")]
  public class AccessWeeklySchedule : ObjectBase
  {
    [XmlElement(DataType = "string", ElementName = "wednesdayDailyCrossingScheduleDescription", IsNullable = true)]
    public string WednesdayDailyCrossingScheduleDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "mondayDailyCrossingScheduleDescription", IsNullable = true)]
    public string MondayDailyCrossingScheduleDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "tuesdayDailyCrossingScheduleDescription", IsNullable = true)]
    public string TuesdayDailyCrossingScheduleDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "fridayDailyCrossingScheduleDescription", IsNullable = true)]
    public string FridayDailyCrossingScheduleDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "saturdayDailyCrossingScheduleDescription", IsNullable = true)]
    public string SaturdayDailyCrossingScheduleDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "thursdayDailyCrossingScheduleDescription", IsNullable = true)]
    public string ThursdayDailyCrossingScheduleDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "sundayDailyCrossingScheduleDescription", IsNullable = true)]
    public string SundayDailyCrossingScheduleDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "publicHolidayDailyCrossingScheduleDescription", IsNullable = true)]
    public string PublicHolidayDailyCrossingScheduleDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "scheduleDescription", IsNullable = true)]
    public string ScheduleDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "scheduleKey", IsNullable = true)]
    public int? ScheduleKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "colourCode", IsNullable = true)]
    public int? ColourCode { get; set; }
  }
}
