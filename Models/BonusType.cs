
// Type: KelioSDK.Models.BonusType




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "BonusType")]
  public class BonusType : Type
  {
    [XmlElement(DataType = "boolean", ElementName = "visualizedInThePrintouts", IsNullable = true)]
    public bool? VisualizedInThePrintouts { get; set; }

    [XmlElement(DataType = "date", ElementName = "resetDate", IsNullable = true)]
    public DateTime? ResetDate { get; set; }
  }
}
