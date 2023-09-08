
// Type: KelioSDK.Models.EndOfPeriodCalendar




using KelioSDK.Common;
using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "EndOfPeriodCalendar")]
  public class EndOfPeriodCalendar : ObjectBase
  {
    [XmlElement(DataType = "int", ElementName = "endOfPeriodCalendarKey", IsNullable = true)]
    public int? EndOfPeriodCalendarKey { get; set; }

    [XmlElement(DataType = "double", ElementName = "flexileaveAbsenceMaxInDay", IsNullable = true)]
    public double? FlexileaveAbsenceMaxInDay { get; set; }

    [XmlElement(DataType = "double", ElementName = "flexileaveAbsenceMaxInHour", IsNullable = true)]
    public double? FlexileaveAbsenceMaxInHour { get; set; }

    [XmlElement(DataType = "string", ElementName = "endOfPeriodCalendarDescription", IsNullable = true)]
    public string EndOfPeriodCalendarDescription { get; set; }

    [XmlElement(DataType = "short", ElementName = "endOfPeriodCalendarType", IsNullable = true)]
    public short? EndOfPeriodCalendarType { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "calculateEndOfPeriodDates", IsNullable = true)]
    public bool? CalculateEndOfPeriodDates { get; set; }

    [XmlElement(DataType = "date", ElementName = "modificationLockingDate", IsNullable = true)]
    public DateTime? ModificationLockingDate { get; set; }

    [XmlElement(DataType = "short", ElementName = "modificationLockingType", IsNullable = true)]
    public short? ModificationLockingType { get; set; }

    [XmlElement(DataType = "short", ElementName = "modificationLockingOffset", IsNullable = true)]
    public short? ModificationLockingOffset { get; set; }

    [XmlElement(DataType = "short", ElementName = "endOfPeriodCalendarDayOfMonth", IsNullable = true)]
    public short? EndOfPeriodCalendarDayOfMonth { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "endOfPeriodCalendarFixedDay", IsNullable = true)]
    public bool? EndOfPeriodCalendarFixedDay { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "endOfPeriodCalendarLastDayOfMonth", IsNullable = true)]
    public bool? EndOfPeriodCalendarLastDayOfMonth { get; set; }

    [XmlElement(DataType = "date", ElementName = "endOfPeriodCalendarRefDate", IsNullable = true)]
    public DateTime? EndOfPeriodCalendarRefDate { get; set; }

    [XmlElement(DataType = "short", ElementName = "endOfPeriodCalendarDayOfWeek", IsNullable = true)]
    public short? EndOfPeriodCalendarDayOfWeek { get; set; }

    [XmlElement(DataType = "date", ElementName = "endOfPeriodCalendarProcessingStartDate", IsNullable = true)]
    public DateTime? EndOfPeriodCalendarProcessingStartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "endOfPeriodCalendarProcessingEndDate", IsNullable = true)]
    public DateTime? EndOfPeriodCalendarProcessingEndDate { get; set; }
  }
}
