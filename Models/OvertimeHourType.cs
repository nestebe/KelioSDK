
// Type: KelioSDK.Models.OvertimeHourType




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "OvertimeHourType")]
  public class OvertimeHourType : Type
  {
    [XmlElement(DataType = "boolean", ElementName = "visualizedInThePrintouts", IsNullable = true)]
    public bool? VisualizedInThePrintouts { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "calculationOverTimeWithItalian", IsNullable = true)]
    public bool? CalculationOverTimeWithItalian { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "calculationOfExoneratedOvertimeHours", IsNullable = true)]
    public bool? CalculationOfExoneratedOvertimeHours { get; set; }

    [XmlElement(DataType = "short", ElementName = "calculationFrequency", IsNullable = true)]
    public short? CalculationFrequency { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "toDeductFromBalance", IsNullable = true)]
    public bool? ToDeductFromBalance { get; set; }

    [XmlElement(DataType = "date", ElementName = "resetDate", IsNullable = true)]
    public DateTime? ResetDate { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "selectedOnTerminalToSuspendBalance", IsNullable = true)]
    public bool? SelectedOnTerminalToSuspendBalance { get; set; }
  }
}
