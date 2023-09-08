
//.ExportOrganizationChartLevelDescriptionsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportOrganizationChartLevelDescriptionsResponse")]
  public class ExportOrganizationChartLevelDescriptionsResponse
  {
    [XmlArray(ElementName = "exportedOrganizationChartLevelDescriptions", IsNullable = false, Order = 0)]
    public List<OrganizationChartLevelDescription> ExportedOrganizationChartLevelDescriptions { get; set; }
  }
}
