
// Type: KelioSDK.Models.ReaderGroup




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "ReaderGroup")]
  public class ReaderGroup : ObjectBase
  {
    [XmlElement(DataType = "int", ElementName = "readerGroupKey", IsNullable = true)]
    public int? ReaderGroupKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "readerGroupDescription", IsNullable = true)]
    public string ReaderGroupDescription { get; set; }
  }
}
