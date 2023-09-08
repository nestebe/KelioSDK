
// Type: KelioSDK.Models.Workbook




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "workbook")]
  public class Workbook : ObjectBase
  {
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

    [XmlElement(DataType = "string", ElementName = "workbookComment", IsNullable = true)]
    public string WorkbookComment { get; set; }
  }
}
