
//.ImportOperatingDataValue




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importOperatingDataValue")]
  public class ImportOperatingDataValue
  {
    [XmlArray(ElementName = "operatingDataValueToImport", IsNullable = false, Order = 0)]
    public List<OperatingDataValue> OperatingDataValueToImport { get; set; }
  }
}
