
// Type: KelioSDK.Models.BonusWindow




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "BonusWindow")]
  public class BonusWindow : DailyScheduleWindow
  {
    [XmlElement(DataType = "boolean", ElementName = "publicHolidaysAffected", IsNullable = true)]
    public bool? PublicHolidaysAffected { get; set; }

    [XmlElement(DataType = "double", ElementName = "minimumTime", IsNullable = true)]
    public double? MinimumTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "weekApplicationDayType", IsNullable = true)]
    public string WeekApplicationDayType { get; set; }

    [XmlElement(DataType = "int", ElementName = "applicationDay", IsNullable = true)]
    public int? ApplicationDay { get; set; }

    [XmlElement(DataType = "double", ElementName = "valueToBeCredited", IsNullable = true)]
    public double? ValueToBeCredited { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "minimumTimeIsRelative", IsNullable = true)]
    public bool? MinimumTimeIsRelative { get; set; }

    [XmlElement(DataType = "int", ElementName = "absencesGroupKey", IsNullable = true)]
    public int? AbsencesGroupKey { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "bonusOnPhysicalDaysCalculation", IsNullable = true)]
    public bool? BonusOnPhysicalDaysCalculation { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "isWithoutBreak", IsNullable = true)]
    public bool? IsWithoutBreak { get; set; }

    [XmlElement(DataType = "string", ElementName = "typeDescription", IsNullable = true)]
    public string TypeDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "absencesGroupDescription", IsNullable = true)]
    public string AbsencesGroupDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "typeKey", IsNullable = true)]
    public int? TypeKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "typeAbbreviation", IsNullable = true)]
    public string TypeAbbreviation { get; set; }

    [XmlElement(DataType = "short", ElementName = "bonusCalculationInCaseOfAbsence", IsNullable = true)]
    public short? BonusCalculationInCaseOfAbsence { get; set; }
  }
}
