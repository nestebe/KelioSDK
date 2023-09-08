
// Type: KelioSDK.Models.Type




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "Type")]
  public class Type : ObjectBase
  {
    [XmlElement(DataType = "boolean", ElementName = "searchUsingExternalReference", IsNullable = true)]
    public bool? SearchUsingExternalReference { get; set; }

    [XmlElement(DataType = "string", ElementName = "defaultExternalReferenceType", IsNullable = true)]
    public string DefaultExternalReferenceType { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "searchUsingDescription", IsNullable = true)]
    public bool? SearchUsingDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "defaultTypeDescription", IsNullable = true)]
    public string DefaultTypeDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "defaultTypeAbbreviation", IsNullable = true)]
    public string DefaultTypeAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "externalReference", IsNullable = true)]
    public string ExternalReference { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "searchUsingAbbreviation", IsNullable = true)]
    public bool? SearchUsingAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "typeDescription", IsNullable = true)]
    public string TypeDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "typeAbbreviation", IsNullable = true)]
    public string TypeAbbreviation { get; set; }

    [XmlElement(DataType = "int", ElementName = "typeKey", IsNullable = true)]
    public int? TypeKey { get; set; }
  }
}
