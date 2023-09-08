
// Type: KelioSDK.Models.ReaderGroupContent




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "readerGroupContent")]
  public class ReaderGroupContent : ObjectBase
  {
    [XmlElement(DataType = "string", ElementName = "readerDescription", IsNullable = true)]
    public string ReaderDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "readerGroupKey", IsNullable = true)]
    public int? ReaderGroupKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "readerGroupDescription", IsNullable = true)]
    public string ReaderGroupDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "readerKey", IsNullable = true)]
    public int? ReaderKey { get; set; }
  }
}
