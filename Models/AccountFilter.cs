
// Type: KelioSDK.Models.AccountFilter




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AccountFilter")]
  public class AccountFilter : PopulationFilter
  {
    [XmlElement(DataType = "int", ElementName = "typeKey", IsNullable = true)]
    public int? TypeKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "calculationMode", IsNullable = true)]
    public int? CalculationMode { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "transferEmptyAccount", IsNullable = true)]
    public bool? TransferEmptyAccount { get; set; }
  }
}
