
// Type: KelioSDK.Models.PublicHolAssigning




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "PublicHolAssigning")]
  public class PublicHolAssigning : EmployeeInformation
  {
    [XmlElement(DataType = "boolean", ElementName = "outOfControlledTotal", IsNullable = true)]
    public bool? OutOfControlledTotal { get; set; }

    [XmlElement(DataType = "date", ElementName = "applicationDate", IsNullable = true)]
    public DateTime? ApplicationDate { get; set; }

    [XmlElement(DataType = "short", ElementName = "holPeriodType", IsNullable = true)]
    public short? HolPeriodType { get; set; }

    [XmlElement(DataType = "short", ElementName = "payment", IsNullable = true)]
    public short? Payment { get; set; }

    [XmlElement(DataType = "double", ElementName = "paidTotal", IsNullable = true)]
    public double? PaidTotal { get; set; }

    [XmlElement(DataType = "double", ElementName = "actualTotal", IsNullable = true)]
    public double? ActualTotal { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "calculationOfExoneratedOvertimeHours", IsNullable = true)]
    public bool? CalculationOfExoneratedOvertimeHours { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "workingDay", IsNullable = true)]
    public bool? WorkingDay { get; set; }
  }
}
