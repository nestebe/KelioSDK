
// Type: KelioSDK.Models.SpecialHourType




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "SpecialHourType")]
  public class SpecialHourType : Type
  {
    [XmlElement(DataType = "boolean", ElementName = "visualizedInThePrintouts", IsNullable = true)]
    public bool? VisualizedInThePrintouts { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "toDeductFromNormalHours", IsNullable = true)]
    public bool? ToDeductFromNormalHours { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "toDeductFromBalance", IsNullable = true)]
    public bool? ToDeductFromBalance { get; set; }

    [XmlElement(DataType = "date", ElementName = "resetDate", IsNullable = true)]
    public DateTime? ResetDate { get; set; }
  }
}
