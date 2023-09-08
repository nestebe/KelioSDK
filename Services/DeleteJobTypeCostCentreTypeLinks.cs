
//.DeleteJobTypeCostCentreTypeLinks




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteJobTypeCostCentreTypeLinks")]
  public class DeleteJobTypeCostCentreTypeLinks
  {
    [XmlArray(ElementName = "jobTypeCostCentreTypeLinksToDelete", IsNullable = false, Order = 0)]
    public List<JobTypeCostCentreTypeLink> JobTypeCostCentreTypeLinksToDelete { get; set; }
  }
}
