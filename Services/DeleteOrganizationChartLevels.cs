
//.DeleteOrganizationChartLevels




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteOrganizationChartLevels")]
  public class DeleteOrganizationChartLevels
  {
    [XmlArray(ElementName = "organizationChartLevelsToDelete", IsNullable = false, Order = 0)]
    public List<OrganizationChartLevel> OrganizationChartLevelsToDelete { get; set; }
  }
}
