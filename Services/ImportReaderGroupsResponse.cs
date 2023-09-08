
//.ImportReaderGroupsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importReaderGroupsResponse")]
  public class ImportReaderGroupsResponse
  {
    [XmlArray(ElementName = "readerGroupsInError", IsNullable = false, Order = 0)]
    public List<ReaderGroup> ReaderGroupsInError { get; set; }
  }
}
