
//.ExportLatenessEarlyDepartureTypesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportLatenessEarlyDepartureTypesResponse")]
  public class ExportLatenessEarlyDepartureTypesResponse
  {
    [XmlArray(ElementName = "exportedLatenessEarlyDepartureTypes", IsNullable = false, Order = 0)]
    public List<LatenessEarlyDepartureType> ExportedLatenessEarlyDepartureTypes { get; set; }
  }
}
