
// Type: KelioSDK.Models.GenericType




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "GenericType")]
  public class GenericType : ObjectBase
  {
    [XmlElement(DataType = "short", ElementName = "unit", IsNullable = true)]
    public short? Unit { get; set; }

    [XmlElement(DataType = "string", ElementName = "code", IsNullable = true)]
    public string Code { get; set; }

    [XmlElement(DataType = "short", ElementName = "calculableType", IsNullable = true)]
    public short? CalculableType { get; set; }

    [XmlElement(DataType = "string", ElementName = "typeDescription", IsNullable = true)]
    public string TypeDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "typeAbbreviation", IsNullable = true)]
    public string TypeAbbreviation { get; set; }

    [XmlElement(DataType = "int", ElementName = "typeKey", IsNullable = true)]
    public int? TypeKey { get; set; }

    [XmlElement(DataType = "short", ElementName = "accountType", IsNullable = true)]
    public short? AccountType { get; set; }
  }
}
