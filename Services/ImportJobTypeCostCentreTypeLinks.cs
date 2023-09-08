
//.ImportJobTypeCostCentreTypeLinks




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importJobTypeCostCentreTypeLinks")]
  public class ImportJobTypeCostCentreTypeLinks
  {
    [XmlArray(ElementName = "jobTypeCostCentreTypeLinksToImport", IsNullable = false, Order = 0)]
    public List<JobTypeCostCentreTypeLink> JobTypeCostCentreTypeLinksToImport { get; set; }
  }
}
