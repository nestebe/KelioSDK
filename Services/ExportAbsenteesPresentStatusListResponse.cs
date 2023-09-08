
//.ExportAbsenteesPresentStatusListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportAbsenteesPresentStatusListResponse")]
  public class ExportAbsenteesPresentStatusListResponse
  {
    [XmlArray(ElementName = "exportedAbsenteesPresentStatus", IsNullable = false, Order = 0)]
    public List<AbsenteesPresentStatus> ExportedAbsenteesPresentStatus { get; set; }
  }
}
