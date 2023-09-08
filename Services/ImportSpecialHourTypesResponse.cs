
//.ImportSpecialHourTypesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importSpecialHourTypesResponse")]
  public class ImportSpecialHourTypesResponse
  {
    [XmlArray(ElementName = "specialHourTypesInError", IsNullable = false, Order = 0)]
    public List<SpecialHourType> SpecialHourTypesInError { get; set; }
  }
}
