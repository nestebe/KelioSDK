
//.ExportOrganizationChartLevelDescriptionsForLevelResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportOrganizationChartLevelDescriptionsForLevelResponse")]
  public class ExportOrganizationChartLevelDescriptionsForLevelResponse
  {
    [XmlArray(ElementName = "exportedOrganizationChartLevelDescriptionsForLevel", IsNullable = false, Order = 0)]
    public List<OrganizationChartLevelDescription> ExportedOrganizationChartLevelDescriptionsForLevel { get; set; }
  }
}
