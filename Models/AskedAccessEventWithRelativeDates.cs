
// Type: KelioSDK.Models.AskedAccessEventWithRelativeDates




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "askedAccessEventWithRelativeDates")]
  public class AskedAccessEventWithRelativeDates : AskedAccessEvent
  {
    [XmlElement(DataType = "int", ElementName = "startOffset", IsNullable = true)]
    public int? StartOffset { get; set; }

    [XmlElement(DataType = "int", ElementName = "endOffset", IsNullable = true)]
    public int? EndOffset { get; set; }
  }
}
