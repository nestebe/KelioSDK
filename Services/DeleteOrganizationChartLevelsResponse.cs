
//.DeleteOrganizationChartLevelsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteOrganizationChartLevelsResponse")]
  public class DeleteOrganizationChartLevelsResponse
  {
    [XmlArray(ElementName = "organizationChartLevelsInError", IsNullable = false, Order = 0)]
    public List<OrganizationChartLevel> OrganizationChartLevelsInError { get; set; }
  }
}
