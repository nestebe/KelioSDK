
// Type: KelioSDK.Models.PeriodJobTotal




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "PeriodJobTotal")]
  public class PeriodJobTotal : AbstractJobTotal
  {
    [XmlElement(DataType = "double", ElementName = "cost", IsNullable = true)]
    public double? Cost { get; set; }

    [XmlElement(DataType = "double", ElementName = "days", IsNullable = true)]
    public double? Days { get; set; }

    [XmlElement(DataType = "date", ElementName = "periodEndDate", IsNullable = true)]
    public DateTime? PeriodEndDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "periodStartDate", IsNullable = true)]
    public DateTime? PeriodStartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "startDate", IsNullable = true)]
    public DateTime? StartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "endDate", IsNullable = true)]
    public DateTime? EndDate { get; set; }

    [XmlElement(DataType = "double", ElementName = "hours", IsNullable = true)]
    public double? Hours { get; set; }

    [XmlElement(DataType = "string", ElementName = "payrollCalendarDescription", IsNullable = true)]
    public string PayrollCalendarDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "payrollCalendarKey", IsNullable = true)]
    public int? PayrollCalendarKey { get; set; }
  }
}
