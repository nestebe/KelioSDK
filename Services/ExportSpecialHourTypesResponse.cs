
//.ExportSpecialHourTypesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportSpecialHourTypesResponse")]
  public class ExportSpecialHourTypesResponse
  {
    [XmlArray(ElementName = "exportedSpecialHourTypes", IsNullable = false, Order = 0)]
    public List<SpecialHourType> ExportedSpecialHourTypes { get; set; }
  }
}
