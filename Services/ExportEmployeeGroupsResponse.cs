
//.ExportEmployeeGroupsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmployeeGroupsResponse")]
  public class ExportEmployeeGroupsResponse
  {
    [XmlArray(ElementName = "exportedEmployeeGroups", IsNullable = false, Order = 0)]
    public List<EmployeeGroup> ExportedEmployeeGroups { get; set; }
  }
}
