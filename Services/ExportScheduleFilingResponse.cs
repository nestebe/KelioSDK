
//.ExportScheduleFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportScheduleFilingResponse")]
  public class ExportScheduleFilingResponse
  {
    [XmlArray(ElementName = "exportedScheduleFiling", IsNullable = false, Order = 0)]
    public List<Filing> ExportedScheduleFiling { get; set; }
  }
}
