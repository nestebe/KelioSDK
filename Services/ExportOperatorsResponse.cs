
//.ExportOperatorsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportOperatorsResponse")]
  public class ExportOperatorsResponse
  {
    [XmlArray(ElementName = "exportedOperators", IsNullable = false, Order = 0)]
    public List<Operator> ExportedOperators { get; set; }
  }
}
