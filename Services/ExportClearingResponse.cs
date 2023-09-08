
//.ExportClearingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportClearingResponse")]
  public class ExportClearingResponse
  {
    [XmlArray(ElementName = "exportedClearing", IsNullable = false, Order = 0)]
    public List<Clearing> ExportedClearing { get; set; }
  }
}
