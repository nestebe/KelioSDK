
// Type: KelioSDK.Models.ScheduleDistribution




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "ScheduleDistribution")]
  public class ScheduleDistribution : ObjectBase
  {
    [XmlElement(DataType = "string", ElementName = "saturdayAutomaticScheduleAbbreviation", IsNullable = true)]
    public string SaturdayAutomaticScheduleAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "sundayDailyScheduleAbbreviation", IsNullable = true)]
    public string SundayDailyScheduleAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "wednesdayDailyScheduleAbbreviation", IsNullable = true)]
    public string WednesdayDailyScheduleAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "wednesdayAutomaticScheduleAbbreviation", IsNullable = true)]
    public string WednesdayAutomaticScheduleAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "sundayAutomaticScheduleAbbreviation", IsNullable = true)]
    public string SundayAutomaticScheduleAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "fridayDailyScheduleAbbreviation", IsNullable = true)]
    public string FridayDailyScheduleAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "fridayAutomaticScheduleAbbreviation", IsNullable = true)]
    public string FridayAutomaticScheduleAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "thursdayDailyScheduleAbbreviation", IsNullable = true)]
    public string ThursdayDailyScheduleAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "mondayDailyScheduleAbbreviation", IsNullable = true)]
    public string MondayDailyScheduleAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "saturdayDailyScheduleAbbreviation", IsNullable = true)]
    public string SaturdayDailyScheduleAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "tuesdayDailyScheduleAbbreviation", IsNullable = true)]
    public string TuesdayDailyScheduleAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "scheduleAbbreviation", IsNullable = true)]
    public string ScheduleAbbreviation { get; set; }

    [XmlElement(DataType = "int", ElementName = "scheduleDistributionKey", IsNullable = true)]
    public int? ScheduleDistributionKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "scheduleDescription", IsNullable = true)]
    public string ScheduleDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "weekDescription", IsNullable = true)]
    public string WeekDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "weekRank", IsNullable = true)]
    public int? WeekRank { get; set; }

    [XmlElement(DataType = "string", ElementName = "thursdayAutomaticScheduleAbbreviation", IsNullable = true)]
    public string ThursdayAutomaticScheduleAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "mondayAutomaticScheduleAbbreviation", IsNullable = true)]
    public string MondayAutomaticScheduleAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "tuesdayAutomaticScheduleAbbreviation", IsNullable = true)]
    public string TuesdayAutomaticScheduleAbbreviation { get; set; }
  }
}
