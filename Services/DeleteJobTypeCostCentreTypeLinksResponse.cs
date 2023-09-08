
//.DeleteJobTypeCostCentreTypeLinksResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteJobTypeCostCentreTypeLinksResponse")]
  public class DeleteJobTypeCostCentreTypeLinksResponse
  {
    [XmlArray(ElementName = "jobTypeCostCentreTypeLinksInError", IsNullable = false, Order = 0)]
    public List<JobTypeCostCentreTypeLink> JobTypeCostCentreTypeLinksInError { get; set; }
  }
}
