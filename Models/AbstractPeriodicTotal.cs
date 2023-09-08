
// Type: KelioSDK.Models.AbstractPeriodicTotal




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AbstractPeriodicTotal")]
  public class AbstractPeriodicTotal : AbstractTotal
  {
    [XmlElement(DataType = "date", ElementName = "periodEndDate", IsNullable = true)]
    public DateTime? PeriodEndDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "periodStartDate", IsNullable = true)]
    public DateTime? PeriodStartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "employeeStartDate", IsNullable = true)]
    public DateTime? EmployeeStartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "employeeEndDate", IsNullable = true)]
    public DateTime? EmployeeEndDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "payrollCalendarDescription", IsNullable = true)]
    public string PayrollCalendarDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "payrollCalendarKey", IsNullable = true)]
    public int? PayrollCalendarKey { get; set; }
  }
}
