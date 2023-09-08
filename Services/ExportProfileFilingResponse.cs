
//.ExportProfileFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportProfileFilingResponse")]
  public class ExportProfileFilingResponse
  {
    [XmlArray(ElementName = "exportedProfileFiling", IsNullable = false, Order = 0)]
    public List<Filing> ExportedProfileFiling { get; set; }
  }
}
