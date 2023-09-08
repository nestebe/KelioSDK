
//.ExportAbsenteesPresentStatusList




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportAbsenteesPresentStatusList")]
  public class ExportAbsenteesPresentStatusList
  {
    [XmlArray(ElementName = "exportFilter", IsNullable = false, Order = 0)]
    public List<AskedAbsenteesPresentStatus> ExportFilter { get; set; }
  }
}
