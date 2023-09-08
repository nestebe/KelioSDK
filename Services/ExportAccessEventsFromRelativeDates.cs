
//.ExportAccessEventsFromRelativeDates




using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportAccessEventsFromRelativeDates")]
  public class ExportAccessEventsFromRelativeDates
  {
    [XmlElement(DataType = "string", ElementName = "eventType", IsNullable = true, Order = 0)]
    public string EventType { get; set; }

    [XmlElement(DataType = "int", ElementName = "startOffset", IsNullable = true, Order = 1)]
    public int? StartOffset { get; set; }

    [XmlElement(DataType = "int", ElementName = "endOffset", IsNullable = true, Order = 2)]
    public int? EndOffset { get; set; }
  }
}
