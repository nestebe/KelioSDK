
//.ExportToilCalendarFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportToilCalendarFilingResponse")]
  public class ExportToilCalendarFilingResponse
  {
    [XmlArray(ElementName = "exportedToilCalendarFiling", IsNullable = false, Order = 0)]
    public List<Filing> ExportedToilCalendarFiling { get; set; }
  }
}
