
// Type: KelioSDK.Models.WeeklyAbsenceBalanceTotal




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "WeeklyAbsenceBalanceTotal")]
  public class WeeklyAbsenceBalanceTotal : AbstractWeeklyTotal
  {
    [XmlElement(DataType = "double", ElementName = "startDays", IsNullable = true)]
    public double? StartDays { get; set; }

    [XmlElement(DataType = "double", ElementName = "startHours", IsNullable = true)]
    public double? StartHours { get; set; }

    [XmlElement(DataType = "double", ElementName = "gainedHours", IsNullable = true)]
    public double? GainedHours { get; set; }

    [XmlElement(DataType = "double", ElementName = "gainedDays", IsNullable = true)]
    public double? GainedDays { get; set; }

    [XmlElement(DataType = "double", ElementName = "endHours", IsNullable = true)]
    public double? EndHours { get; set; }

    [XmlElement(DataType = "double", ElementName = "endDays", IsNullable = true)]
    public double? EndDays { get; set; }

    [XmlElement(DataType = "double", ElementName = "adjustmentDays", IsNullable = true)]
    public double? AdjustmentDays { get; set; }

    [XmlElement(DataType = "double", ElementName = "adjustmentHours", IsNullable = true)]
    public double? AdjustmentHours { get; set; }

    [XmlElement(DataType = "double", ElementName = "takenDays", IsNullable = true)]
    public double? TakenDays { get; set; }

    [XmlElement(DataType = "double", ElementName = "takenHours", IsNullable = true)]
    public double? TakenHours { get; set; }
  }
}
