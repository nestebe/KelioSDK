
//.ExportOperatingDataValueResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportOperatingDataValueResponse")]
  public class ExportOperatingDataValueResponse
  {
    [XmlArray(ElementName = "exportedOperatingDataValue", IsNullable = false, Order = 0)]
    public List<OperatingDataValue> ExportedOperatingDataValue { get; set; }
  }
}
