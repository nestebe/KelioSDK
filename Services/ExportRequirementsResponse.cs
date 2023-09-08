
//.ExportRequirementsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportRequirementsResponse")]
  public class ExportRequirementsResponse
  {
    [XmlArray(ElementName = "exportedRequirements", IsNullable = false, Order = 0)]
    public List<Requirement> ExportedRequirements { get; set; }
  }
}
