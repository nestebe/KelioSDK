
// Type: KelioSDK.Models.PublicHolydaySetup




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "PublicHolydaySetup")]
  public class PublicHolydaySetup : ObjectBase
  {
    [XmlElement(DataType = "boolean", ElementName = "holydayInContractedTotal", IsNullable = true)]
    public bool? HolydayInContractedTotal { get; set; }

    [XmlElement(DataType = "string", ElementName = "description", IsNullable = true)]
    public string Description { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "publicHolidaysOnPhysicalDaysCalculation", IsNullable = true)]
    public bool? PublicHolidaysOnPhysicalDaysCalculation { get; set; }
  }
}
