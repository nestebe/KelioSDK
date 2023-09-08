
//.ExportOperatingDataValue




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportOperatingDataValue")]
  public class ExportOperatingDataValue
  {
    [XmlArray(ElementName = "exportFilter", IsNullable = false, Order = 0)]
    public List<AskedOperatingDataValue> ExportFilter { get; set; }
  }
}
