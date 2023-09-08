
// Type: KelioSDK.Models.AddDeductWindow




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AddDeductWindow")]
  public class AddDeductWindow : DailyScheduleWindow
  {
    [XmlElement(DataType = "boolean", ElementName = "isCredit", IsNullable = true)]
    public bool? IsCredit { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "modifyBalance", IsNullable = true)]
    public bool? ModifyBalance { get; set; }

    [XmlElement(DataType = "double", ElementName = "value", IsNullable = true)]
    public double? Value { get; set; }

    [XmlElement(DataType = "double", ElementName = "minimumActualTime", IsNullable = true)]
    public double? MinimumActualTime { get; set; }

    [XmlElement(DataType = "double", ElementName = "maximumActualTime", IsNullable = true)]
    public double? MaximumActualTime { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "isWithoutBreak", IsNullable = true)]
    public bool? IsWithoutBreak { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "modifyPaidTotal", IsNullable = true)]
    public bool? ModifyPaidTotal { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "modifyActualTotal", IsNullable = true)]
    public bool? ModifyActualTotal { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "modifyTaxExemptOvertimeHoursTotal", IsNullable = true)]
    public bool? ModifyTaxExemptOvertimeHoursTotal { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "maximumActualTimeIsRelative", IsNullable = true)]
    public bool? MaximumActualTimeIsRelative { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "minimumActualTimeIsRelative", IsNullable = true)]
    public bool? MinimumActualTimeIsRelative { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "modifyAnnualisedHours", IsNullable = true)]
    public bool? ModifyAnnualisedHours { get; set; }
  }
}
