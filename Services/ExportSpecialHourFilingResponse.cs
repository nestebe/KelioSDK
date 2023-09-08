
//.ExportSpecialHourFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportSpecialHourFilingResponse")]
  public class ExportSpecialHourFilingResponse
  {
    [XmlArray(ElementName = "exportedSpecialHourFiling", IsNullable = false, Order = 0)]
    public List<Filing> ExportedSpecialHourFiling { get; set; }
  }
}
