
//.ExportSpecialHourTypeAuthorizationsList




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportSpecialHourTypeAuthorizationsList")]
  public class ExportSpecialHourTypeAuthorizationsList
  {
    [XmlArray(ElementName = "exportFilter", IsNullable = false, Order = 0)]
    public List<AskedPopulationWithPeriod> ExportFilter { get; set; }
  }
}
