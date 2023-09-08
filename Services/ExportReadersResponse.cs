
//.ExportReadersResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportReadersResponse")]
  public class ExportReadersResponse
  {
    [XmlArray(ElementName = "exportedReaders", IsNullable = false, Order = 0)]
    public List<Reader> ExportedReaders { get; set; }
  }
}
