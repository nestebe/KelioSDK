
//.ExportEmployeeGroupDescriptionsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmployeeGroupDescriptionsResponse")]
  public class ExportEmployeeGroupDescriptionsResponse
  {
    [XmlArray(ElementName = "exportedEmployeeGroupDescription", IsNullable = false, Order = 0)]
    public List<SimpleEmployeeGroup> ExportedEmployeeGroupDescription { get; set; }
  }
}
