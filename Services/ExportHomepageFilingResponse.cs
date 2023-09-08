
//.ExportHomepageFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportHomepageFilingResponse")]
  public class ExportHomepageFilingResponse
  {
    [XmlArray(ElementName = "exportedHomepageFiling", IsNullable = false, Order = 0)]
    public List<Filing> ExportedHomepageFiling { get; set; }
  }
}
