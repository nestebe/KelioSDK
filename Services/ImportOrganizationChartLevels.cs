
//.ImportOrganizationChartLevels




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importOrganizationChartLevels")]
  public class ImportOrganizationChartLevels
  {
    [XmlArray(ElementName = "organizationChartLevelsToImport", IsNullable = false, Order = 0)]
    public List<OrganizationChartLevel> OrganizationChartLevelsToImport { get; set; }
  }
}
