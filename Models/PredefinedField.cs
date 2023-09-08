
// Type: KelioSDK.Models.PredefinedField




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "PredefinedField")]
  public class PredefinedField : ObjectBase
  {
    [XmlElement(DataType = "boolean", ElementName = "searchUsingValueAbbreviation", IsNullable = true)]
    public bool? SearchUsingValueAbbreviation { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "searchUsingValueDescription", IsNullable = true)]
    public bool? SearchUsingValueDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "predefinedFieldValue", IsNullable = true)]
    public string PredefinedFieldValue { get; set; }

    [XmlElement(DataType = "string", ElementName = "predefinedFieldAbbreviation", IsNullable = true)]
    public string PredefinedFieldAbbreviation { get; set; }

    [XmlElement(DataType = "int", ElementName = "predefinedFieldValueLevel", IsNullable = true)]
    public int? PredefinedFieldValueLevel { get; set; }

    [XmlElement(DataType = "string", ElementName = "predefinedFieldComment", IsNullable = true)]
    public string PredefinedFieldComment { get; set; }

    [XmlElement(DataType = "string", ElementName = "predefinedFieldDescription", IsNullable = true)]
    public string PredefinedFieldDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "predefinedFieldKey", IsNullable = true)]
    public int? PredefinedFieldKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "predefinedFieldDataAbbreviation", IsNullable = true)]
    public string PredefinedFieldDataAbbreviation { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "isHistorical", IsNullable = true)]
    public bool? IsHistorical { get; set; }

    [XmlElement(DataType = "int", ElementName = "fieldFormat", IsNullable = true)]
    public int? FieldFormat { get; set; }

    [XmlElement(DataType = "int", ElementName = "fieldKey", IsNullable = true)]
    public int? FieldKey { get; set; }
  }
}
