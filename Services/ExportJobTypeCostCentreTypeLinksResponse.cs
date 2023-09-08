
//.ExportJobTypeCostCentreTypeLinksResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportJobTypeCostCentreTypeLinksResponse")]
  public class ExportJobTypeCostCentreTypeLinksResponse
  {
    [XmlArray(ElementName = "exportedJobTypeCostCentreTypeLinks", IsNullable = false, Order = 0)]
    public List<JobTypeCostCentreTypeLink> ExportedJobTypeCostCentreTypeLinks { get; set; }
  }
}
