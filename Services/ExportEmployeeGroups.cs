
//.ExportEmployeeGroups




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmployeeGroups")]
  public class ExportEmployeeGroups
  {
    [XmlArray(ElementName = "arg0", IsNullable = false, Order = 0)]
    public List<AskedEmployeeGroup> Arg0 { get; set; }
  }
}
