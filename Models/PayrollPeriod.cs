
// Type: KelioSDK.Models.PayrollPeriod




using KelioSDK.Common;
using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "PayrollPeriod")]
  public class PayrollPeriod : ObjectBase
  {
    [XmlElement(DataType = "date", ElementName = "startDate", IsNullable = true)]
    public DateTime? StartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "endDate", IsNullable = true)]
    public DateTime? EndDate { get; set; }

    [XmlElement(DataType = "int", ElementName = "payrollPeriodKey", IsNullable = true)]
    public int? PayrollPeriodKey { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "lockedResults", IsNullable = true)]
    public bool? LockedResults { get; set; }

    [XmlElement(DataType = "int", ElementName = "payrollCalendarKey", IsNullable = true)]
    public int? PayrollCalendarKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "payrollCalendarDescription", IsNullable = true)]
    public string PayrollCalendarDescription { get; set; }
  }
}
