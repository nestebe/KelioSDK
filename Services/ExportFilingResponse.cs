
//.ExportFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportFilingResponse")]
  public class ExportFilingResponse
  {
    [XmlArray(ElementName = "exportedFiling", IsNullable = false, Order = 0)]
    public List<GenericFiling> ExportedFiling { get; set; }
  }
}
