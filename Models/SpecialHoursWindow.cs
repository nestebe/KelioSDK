
// Type: KelioSDK.Models.SpecialHoursWindow




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "SpecialHoursWindow")]
  public class SpecialHoursWindow : DailyScheduleWindow
  {
    [XmlElement(DataType = "boolean", ElementName = "maximumTimeIsRelative", IsNullable = true)]
    public bool? MaximumTimeIsRelative { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "publicHolidaysAffected", IsNullable = true)]
    public bool? PublicHolidaysAffected { get; set; }

    [XmlElement(DataType = "double", ElementName = "minimumTime", IsNullable = true)]
    public double? MinimumTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "weekApplicationDayType", IsNullable = true)]
    public string WeekApplicationDayType { get; set; }

    [XmlElement(DataType = "short", ElementName = "applicationDay", IsNullable = true)]
    public short? ApplicationDay { get; set; }

    [XmlElement(DataType = "double", ElementName = "maximumTime", IsNullable = true)]
    public double? MaximumTime { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "minimumTimeIsRelative", IsNullable = true)]
    public bool? MinimumTimeIsRelative { get; set; }

    [XmlElement(DataType = "int", ElementName = "absencesGroupKey", IsNullable = true)]
    public int? AbsencesGroupKey { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "specialHoursOnPhysicalDaysCalculation", IsNullable = true)]
    public bool? SpecialHoursOnPhysicalDaysCalculation { get; set; }

    [XmlElement(DataType = "string", ElementName = "typeDescription", IsNullable = true)]
    public string TypeDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "absencesGroupDescription", IsNullable = true)]
    public string AbsencesGroupDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "typeKey", IsNullable = true)]
    public int? TypeKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "typeAbbreviation", IsNullable = true)]
    public string TypeAbbreviation { get; set; }

    [XmlElement(DataType = "short", ElementName = "specialHoursCalculationInCaseOfAbsence", IsNullable = true)]
    public short? SpecialHoursCalculationInCaseOfAbsence { get; set; }
  }
}
