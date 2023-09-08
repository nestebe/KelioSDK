
//.ExportOrganizationChartLevelDescriptions




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportOrganizationChartLevelDescriptions")]
  public class ExportOrganizationChartLevelDescriptions
  {
    [XmlArray(ElementName = "exportFilter", IsNullable = false, Order = 0)]
    public List<AskedOrganigrammeLevel> ExportFilter { get; set; }
  }
}
