
// Type: KelioSDK.Models.CorrelationTableRiskAccount




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "CorrelationTableRiskAccount")]
  public class CorrelationTableRiskAccount : ObjectBase
  {
    [XmlElement(DataType = "string", ElementName = "typeDescription", IsNullable = true)]
    public string TypeDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "typeAbbreviation", IsNullable = true)]
    public string TypeAbbreviation { get; set; }

    [XmlElement(DataType = "short", ElementName = "accountType", IsNullable = true)]
    public short? AccountType { get; set; }

    [XmlElement(DataType = "short", ElementName = "riskType", IsNullable = true)]
    public short? RiskType { get; set; }

    [XmlElement(DataType = "int", ElementName = "typeKey", IsNullable = true)]
    public int? TypeKey { get; set; }
  }
}
