
// Type: KelioSDK.Models.PublicHoliday




using KelioSDK.Common;
using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "PublicHoliday")]
  public class PublicHoliday : ObjectBase
  {
    [XmlElement(DataType = "int", ElementName = "dayType", IsNullable = true)]
    public int? DayType { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "outOfControlledTotal", IsNullable = true)]
    public bool? OutOfControlledTotal { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "reportCorePublicHolidayOnNextYears", IsNullable = true)]
    public bool? ReportCorePublicHolidayOnNextYears { get; set; }

    [XmlElement(DataType = "date", ElementName = "applicationDate", IsNullable = true)]
    public DateTime? ApplicationDate { get; set; }

    [XmlElement(DataType = "int", ElementName = "paidType", IsNullable = true)]
    public int? PaidType { get; set; }

    [XmlElement(DataType = "short", ElementName = "payment", IsNullable = true)]
    public short? Payment { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "corePublicHoliday", IsNullable = true)]
    public bool? CorePublicHoliday { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "workedDay", IsNullable = true)]
    public bool? WorkedDay { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "calculationOfExoneratedOvertimeHours", IsNullable = true)]
    public bool? CalculationOfExoneratedOvertimeHours { get; set; }

    [XmlElement(DataType = "string", ElementName = "calendarDescription", IsNullable = true)]
    public string CalendarDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "calendarKey", IsNullable = true)]
    public int? CalendarKey { get; set; }
  }
}
