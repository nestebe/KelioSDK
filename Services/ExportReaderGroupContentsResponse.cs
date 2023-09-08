
//.ExportReaderGroupContentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportReaderGroupContentsResponse")]
  public class ExportReaderGroupContentsResponse
  {
    [XmlArray(ElementName = "exportedReaderGroupContents", IsNullable = false, Order = 0)]
    public List<ReaderGroupContent> ExportedReaderGroupContents { get; set; }
  }
}
