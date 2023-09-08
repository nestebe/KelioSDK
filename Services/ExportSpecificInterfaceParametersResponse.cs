
//.ExportSpecificInterfaceParametersResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportSpecificInterfaceParametersResponse")]
  public class ExportSpecificInterfaceParametersResponse
  {
    [XmlArray(ElementName = "exportedSpecificInterfaceParameters", IsNullable = false, Order = 0)]
    public List<SpecificInterfaceParameter> ExportedSpecificInterfaceParameters { get; set; }
  }
}
