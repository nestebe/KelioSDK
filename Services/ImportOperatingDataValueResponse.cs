
//.ImportOperatingDataValueResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importOperatingDataValueResponse")]
  public class ImportOperatingDataValueResponse
  {
    [XmlArray(ElementName = "operatingDataValueInError", IsNullable = false, Order = 0)]
    public List<OperatingDataValue> OperatingDataValueInError { get; set; }
  }
}
