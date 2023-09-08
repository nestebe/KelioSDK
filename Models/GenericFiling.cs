
// Type: KelioSDK.Models.GenericFiling




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "genericFiling")]
  public class GenericFiling : ObjectBase
  {
    [XmlElement(DataType = "int", ElementName = "filingType", IsNullable = true)]
    public int? FilingType { get; set; }

    [XmlElement(DataType = "int", ElementName = "workbookType", IsNullable = true)]
    public int? WorkbookType { get; set; }

    [XmlElement(DataType = "int", ElementName = "entityKey", IsNullable = true)]
    public int? EntityKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "workbookKey", IsNullable = true)]
    public int? WorkbookKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "entityDescription", IsNullable = true)]
    public string EntityDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "workbookDescription", IsNullable = true)]
    public string WorkbookDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "elementDescription", IsNullable = true)]
    public string ElementDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "valueAbbreviation", IsNullable = true)]
    public string ValueAbbreviation { get; set; }

    [XmlElement(DataType = "int", ElementName = "elementKey", IsNullable = true)]
    public int? ElementKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "filingKey", IsNullable = true)]
    public int? FilingKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "valueDescription", IsNullable = true)]
    public string ValueDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "elementAbbreviation", IsNullable = true)]
    public string ElementAbbreviation { get; set; }
  }
}
