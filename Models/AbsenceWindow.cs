
// Type: KelioSDK.Models.AbsenceWindow




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AbsenceWindow")]
  public class AbsenceWindow : DailyScheduleWindow
  {
    [XmlElement(DataType = "double", ElementName = "totalInDays", IsNullable = true)]
    public double? TotalInDays { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "completeAbsenceRequiredTimeRelative", IsNullable = true)]
    public bool? CompleteAbsenceRequiredTimeRelative { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "publicHolidaysAffected", IsNullable = true)]
    public bool? PublicHolidaysAffected { get; set; }

    [XmlElement(DataType = "double", ElementName = "annualisedHoursStandardTime", IsNullable = true)]
    public double? AnnualisedHoursStandardTime { get; set; }

    [XmlElement(DataType = "double", ElementName = "backFromAbsenceAllowance", IsNullable = true)]
    public double? BackFromAbsenceAllowance { get; set; }

    [XmlElement(DataType = "double", ElementName = "completeAbsenceRequiredTime", IsNullable = true)]
    public double? CompleteAbsenceRequiredTime { get; set; }

    [XmlElement(DataType = "double", ElementName = "onLeaveAllowance", IsNullable = true)]
    public double? OnLeaveAllowance { get; set; }

    [XmlElement(DataType = "int", ElementName = "absencesGroupKey", IsNullable = true)]
    public int? AbsencesGroupKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "absencesGroupDescription", IsNullable = true)]
    public string AbsencesGroupDescription { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "annualisedHoursStandardTimeRelative", IsNullable = true)]
    public bool? AnnualisedHoursStandardTimeRelative { get; set; }
  }
}
